using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MegaPaint
{
    public partial class MainWindow : Form
    {
        #region Variables
            private bool extraVisible;
            private int prevX;
            private int prevY;
            private bool isDrowing;
            private Color penColor;
            private float penWidth;
            Bitmap DrawArea;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            InitialisePaintComponents();
        }

        #region Events
            private void MainWindow_Load(object sender, EventArgs e)
            {
                isDrowing = false;
            }
            private void MainWindow_MouseDown(object sender, MouseEventArgs e)
            {
                isDrowing = true;
                prevX = e.X;
                prevY = e.Y;
            }
            private void MainWindow_MouseUp(object sender, MouseEventArgs e)
            {
                isDrowing = false;
            }
            private void MainWindow_MouseMove(object sender, MouseEventArgs e)
            {
                DrawingMethod(e);
            }
            private void Clear_btn_Click(object sender, EventArgs e)
            {
                Clear_Drawing_area();
            }
            private void Save_btn_Click(object sender, EventArgs e)
            {
                SaveFile();
            }
            private void Load_btn_Click(object sender, EventArgs e)
            {
                LoadFile();
            }
            private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
            {
                penWidth = SizeTrackBar.Value;
            }
            private void ColorPickerDialogBTN_Click(object sender, EventArgs e)
            {
                InvokeColorPicker();
            }
            private void RandomColorCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                RandomGreyColorCheckBox.Checked = false;
            }
            private void RandomGreyColorCheckBox_CheckedChanged(object sender, EventArgs e)
            {
                RandomColorCheckBox.Checked = false;
            }
            private void ExtrasBTN_Click(object sender, EventArgs e)
        {
            VisibleToggle();
        }
        #endregion

        #region Functional methods

            /// <summary>
            /// Initialise all components and variables
            /// </summary>
            private void InitialisePaintComponents()
            {
                penWidth = 1;
                penColor = Color.Black;
                extraVisible = true;
                SizeTrackBar.SetRange(1, 15);
                DrawArea = new Bitmap(Drawing_pb.Size.Width, Drawing_pb.Size.Height);
                RandomColorCheckBox.Checked = false;
                RandomGreyColorCheckBox.Checked = false;
                RandomWidthCheckBox.Checked = false;
            }

            /// <summary>
            /// Main drawing method by mousemove
            /// </summary>
            /// <param name="e"></param>
            private void DrawingMethod(MouseEventArgs e)
            {

                if (isDrowing == true)
                {
                    if (RandomColorCheckBox.Checked)
                    {
                        RandomGreyColorCheckBox.Checked = false;
                        penColor = RanCol();
                    }
                    if (RandomGreyColorCheckBox.Checked)
                    {
                        RandomColorCheckBox.Checked = false;
                        penColor = Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
                    }

                    if (RandomWidthCheckBox.Checked)
                    {
                        penWidth = new Random().Next(1, 15);
                    }
                    Graphics g = Graphics.FromImage(DrawArea);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.DrawLine(new Pen(penColor, penWidth), prevX, prevY, e.X, e.Y);
                    prevX = e.X;
                    prevY = e.Y;
                    Drawing_pb.Image = DrawArea;
                }
            }

            /// <summary>
            /// ColorPicker invoker
            /// </summary>
            private void InvokeColorPicker()
            {
                ColorDialog dialogColor = new ColorDialog();

                if (dialogColor.ShowDialog() == DialogResult.OK)
                {
                    penColor = dialogColor.Color;
                }
            }

            /// <summary>
            /// Color randomisation
            /// </summary>
            /// <returns>Random color from Color.Enum</returns>
            private Color RanCol2()
            {
                Random randomGen = new Random();
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = names[randomGen.Next(names.Length)];
                Color randomColor = Color.FromKnownColor(randomColorName);
                return randomColor;
            }
            
            private Color RanCol()
        {
            Random r = new Random();

            return Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }

            /// <summary>
            /// Extra method for Extras panel
            /// Toggles visibility state
            /// </summary>
            private void VisibleToggle()
            {
                if (extraVisible)
                {
                    RandomColorCheckBox.Visible = true;
                    RandomGreyColorCheckBox.Visible = true;
                    RandomWidthCheckBox.Visible = true;
                    extraVisible = false;
                }
                else
                {
                    RandomColorCheckBox.Visible = false;
                    RandomGreyColorCheckBox.Visible = false;
                    RandomWidthCheckBox.Visible = false;
                    extraVisible = true;
                }
            }

            /// <summary>
            /// Clear method
            /// </summary>
            private void Clear_Drawing_area()
            {
                DrawArea = new Bitmap(Drawing_pb.Size.Width, Drawing_pb.Size.Height);
                Drawing_pb.Image = DrawArea;
                this.Refresh();
            }

            /// <summary>
            /// Invoke save dialog
            /// Save to some extentions
            /// </summary>
            private void SaveFile()
            {
                SaveDialog.Filter = "Image Files(*.BMP;)|*.BMP|Image Files(*.JPG;)|*.jpg|Image Files(*.GIF;)|*.gif|Image Files(*.PNG;)|*.png|Image Files(*.TIFF;)|*.tiff|Image Files(*.ICON;)|*.ico;";
                if (SaveDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                Bitmap saveFile = new Bitmap(Drawing_pb.Width, Drawing_pb.Height);
                Drawing_pb.DrawToBitmap(saveFile, Drawing_pb.ClientRectangle);

                string path = SaveDialog.FileName;
                if (path != "")
                {
                    switch ((path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower())
                    {
                        case "jpg":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case "bmp":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case "gif":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case "png":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case "tiff":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;
                        case "ico":
                            saveFile.Save(path, System.Drawing.Imaging.ImageFormat.Icon);
                            break;
                    }
                }
                SaveDialog.Dispose();
            }

            /// <summary>
            /// Invoke open dialog
            /// open from some extentions
            /// </summary>
            private void LoadFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();

            openFD.Filter = "Image Files(*.BMP;)|*.BMP|Image Files(*.JPG;)|*.jpg|Image Files(*.GIF;)|*.gif|Image Files(*.PNG;)|*.png|Image Files(*.TIFF;)|*.tiff|Image Files(*.ICON;)|*.ico;";

            if (openFD.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string path = openFD.FileName;
            Clear_Drawing_area();
            DrawArea = new Bitmap(path);
            Drawing_pb.Image = DrawArea;

            openFD.Dispose();
        }

        #endregion
    }
}