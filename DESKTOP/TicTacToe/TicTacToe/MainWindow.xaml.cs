using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetGameButtons();
        }

        private Button[,] GetGameButtons()
        {
            Button[,] btnsArr = new Button[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btnsArr[i, j] = (Button)this.FindName("button" + i.ToString() + j.ToString());
                }
            }
            return btnsArr;
        }

        private void game_btn_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content == "")
            {
                (sender as Button).Content = "X";

                if (Win(WinCheck()) != true)
                {
                    AI();

                    Win(WinCheck());
                }
            }
        }

        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button btn in GetGameButtons())
            {
                btn.IsEnabled = true;
            }
            clear_btn.IsEnabled = true;
            (sender as Button).IsEnabled = false;
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            win_lbl.Content = "";
            foreach (Button btn in GetGameButtons())
            {
                btn.Content = "";
                btn.IsEnabled = false;
            }
            start_btn.IsEnabled = true;
            (sender as Button).IsEnabled = false;
        }

        private string WinCheck()
        {
            Button[,] btns = GetGameButtons();
            string cross = "X", zero = "O";
            #region
            if (btns[0, 0].Content == cross && btns[0, 1].Content == cross && btns[0, 2].Content == cross ||
                btns[1, 0].Content == cross && btns[1, 1].Content == cross && btns[1, 2].Content == cross ||
                btns[2, 0].Content == cross && btns[2, 1].Content == cross && btns[2, 2].Content == cross ||
                btns[0, 0].Content == cross && btns[1, 0].Content == cross && btns[2, 0].Content == cross ||
                btns[0, 1].Content == cross && btns[1, 1].Content == cross && btns[2, 1].Content == cross ||
                btns[0, 2].Content == cross && btns[1, 2].Content == cross && btns[2, 2].Content == cross ||
                btns[0, 0].Content == cross && btns[1, 1].Content == cross && btns[2, 2].Content == cross ||
                btns[0, 2].Content == cross && btns[1, 1].Content == cross && btns[2, 0].Content == cross)
            {
                return ("Player " + cross + " winner");
            }
            #endregion
            #region
            if (btns[0, 0].Content == zero && btns[0, 1].Content == zero && btns[0, 2].Content == zero ||
                btns[1, 0].Content == zero && btns[1, 1].Content == zero && btns[1, 2].Content == zero ||
                btns[2, 0].Content == zero && btns[2, 1].Content == zero && btns[2, 2].Content == zero ||
                btns[0, 0].Content == zero && btns[1, 0].Content == zero && btns[2, 0].Content == zero ||
                btns[0, 1].Content == zero && btns[1, 1].Content == zero && btns[2, 1].Content == zero ||
                btns[0, 2].Content == zero && btns[1, 2].Content == zero && btns[2, 2].Content == zero ||
                btns[0, 0].Content == zero && btns[1, 1].Content == zero && btns[2, 2].Content == zero ||
                btns[0, 2].Content == zero && btns[1, 1].Content == zero && btns[2, 0].Content == zero)
            {
                return ("Player " + zero + " winner");
            }
            #endregion
            return "";
        }

        private void AI()
        {
            List<Button> btns = new List<Button>();

            foreach (Button btn in GetGameButtons())
            {
                if (btn.IsEnabled == true)
                {
                    if (btn.Content == "")
                    {
                        btns.Add(btn);
                    }
                }
                else
                    return;
            }
            Random r = new Random();
            if (btns.Count!=0)
            {
                btns[r.Next(0, btns.Count())].Content = "O";
            }
            else
            {
                Win("Nobody wins");
            }
        }

        private bool Win(string msg)
        {
            if (msg == "")
            {
                return false;
            }
            win_lbl.Content = msg;
            foreach (Button btn in GetGameButtons())
            {
                btn.IsEnabled = false;
            }
            return true;
        }
    }
}
