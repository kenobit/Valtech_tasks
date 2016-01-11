namespace MegaPaint
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.ColorPickerDialogBTN = new System.Windows.Forms.ToolStripButton();
            this.BrushSizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.SizeTrackBar = new System.Windows.Forms.TrackBar();
            this.RandomColorCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomWidthCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomGreyColorCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtrasBTN = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Drawing_pb = new System.Windows.Forms.PictureBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Load_btn = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TopMenu.AllowMerge = false;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorPickerDialogBTN,
            this.BrushSizeLabel});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(897, 25);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "toolStrip1";
            // 
            // ColorPickerDialogBTN
            // 
            this.ColorPickerDialogBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorPickerDialogBTN.Image = ((System.Drawing.Image)(resources.GetObject("ColorPickerDialogBTN.Image")));
            this.ColorPickerDialogBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorPickerDialogBTN.Name = "ColorPickerDialogBTN";
            this.ColorPickerDialogBTN.Size = new System.Drawing.Size(75, 22);
            this.ColorPickerDialogBTN.Text = "Color picker";
            this.ColorPickerDialogBTN.Click += new System.EventHandler(this.ColorPickerDialogBTN_Click);
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(62, 22);
            this.BrushSizeLabel.Text = "Brush size:";
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.AutoSize = false;
            this.SizeTrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SizeTrackBar.Location = new System.Drawing.Point(145, 0);
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(104, 25);
            this.SizeTrackBar.TabIndex = 1;
            this.SizeTrackBar.Value = 5;
            this.SizeTrackBar.ValueChanged += new System.EventHandler(this.SizeTrackBar_ValueChanged);
            // 
            // RandomColorCheckBox
            // 
            this.RandomColorCheckBox.AutoSize = true;
            this.RandomColorCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RandomColorCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandomColorCheckBox.Location = new System.Drawing.Point(554, 5);
            this.RandomColorCheckBox.Name = "RandomColorCheckBox";
            this.RandomColorCheckBox.Size = new System.Drawing.Size(92, 17);
            this.RandomColorCheckBox.TabIndex = 2;
            this.RandomColorCheckBox.Text = "Random color";
            this.RandomColorCheckBox.UseVisualStyleBackColor = false;
            this.RandomColorCheckBox.Visible = false;
            this.RandomColorCheckBox.CheckedChanged += new System.EventHandler(this.RandomColorCheckBox_CheckedChanged);
            // 
            // RandomWidthCheckBox
            // 
            this.RandomWidthCheckBox.AutoSize = true;
            this.RandomWidthCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RandomWidthCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandomWidthCheckBox.Location = new System.Drawing.Point(800, 5);
            this.RandomWidthCheckBox.Name = "RandomWidthCheckBox";
            this.RandomWidthCheckBox.Size = new System.Drawing.Size(94, 17);
            this.RandomWidthCheckBox.TabIndex = 3;
            this.RandomWidthCheckBox.Text = "Random width";
            this.RandomWidthCheckBox.UseVisualStyleBackColor = false;
            this.RandomWidthCheckBox.Visible = false;
            // 
            // RandomGreyColorCheckBox
            // 
            this.RandomGreyColorCheckBox.AutoSize = true;
            this.RandomGreyColorCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RandomGreyColorCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandomGreyColorCheckBox.Location = new System.Drawing.Point(652, 5);
            this.RandomGreyColorCheckBox.Name = "RandomGreyColorCheckBox";
            this.RandomGreyColorCheckBox.Size = new System.Drawing.Size(142, 17);
            this.RandomGreyColorCheckBox.TabIndex = 4;
            this.RandomGreyColorCheckBox.Text = "Random Greyscale color";
            this.RandomGreyColorCheckBox.UseVisualStyleBackColor = false;
            this.RandomGreyColorCheckBox.Visible = false;
            this.RandomGreyColorCheckBox.CheckedChanged += new System.EventHandler(this.RandomGreyColorCheckBox_CheckedChanged);
            // 
            // ExtrasBTN
            // 
            this.ExtrasBTN.Location = new System.Drawing.Point(502, 2);
            this.ExtrasBTN.Name = "ExtrasBTN";
            this.ExtrasBTN.Size = new System.Drawing.Size(46, 23);
            this.ExtrasBTN.TabIndex = 5;
            this.ExtrasBTN.Text = "Extras";
            this.ExtrasBTN.UseVisualStyleBackColor = true;
            this.ExtrasBTN.Click += new System.EventHandler(this.ExtrasBTN_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(255, 1);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(41, 23);
            this.Clear_btn.TabIndex = 6;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Drawing_pb
            // 
            this.Drawing_pb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drawing_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drawing_pb.Location = new System.Drawing.Point(0, 26);
            this.Drawing_pb.Name = "Drawing_pb";
            this.Drawing_pb.Size = new System.Drawing.Size(897, 618);
            this.Drawing_pb.TabIndex = 7;
            this.Drawing_pb.TabStop = false;
            this.Drawing_pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.Drawing_pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.Drawing_pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(302, 1);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save image";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(383, 1);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(75, 23);
            this.Load_btn.TabIndex = 9;
            this.Load_btn.Text = "Load image";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(897, 644);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Drawing_pb);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.ExtrasBTN);
            this.Controls.Add(this.RandomGreyColorCheckBox);
            this.Controls.Add(this.RandomWidthCheckBox);
            this.Controls.Add(this.RandomColorCheckBox);
            this.Controls.Add(this.SizeTrackBar);
            this.Controls.Add(this.TopMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The best paint ever!!!";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar SizeTrackBar;
        public System.Windows.Forms.ToolStrip TopMenu;
        private System.Windows.Forms.ToolStripLabel BrushSizeLabel;
        private System.Windows.Forms.ToolStripButton ColorPickerDialogBTN;
        private System.Windows.Forms.CheckBox RandomColorCheckBox;
        private System.Windows.Forms.CheckBox RandomWidthCheckBox;
        private System.Windows.Forms.CheckBox RandomGreyColorCheckBox;
        private System.Windows.Forms.Button ExtrasBTN;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.PictureBox Drawing_pb;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
    }
}

