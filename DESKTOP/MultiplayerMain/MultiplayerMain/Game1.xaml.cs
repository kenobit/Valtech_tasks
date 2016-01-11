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
using System.Windows.Shapes;

namespace MultiplayerMain
{
    /// <summary>
    /// Interaction logic for Game1.xaml
    /// </summary>
    public partial class Game1 : Window, IServer
    {
        //List<IClient>
        MainWindow mainWnd;
        List<Player> players;
        List<string> words = new List<string>();
        int[] scores;

        public Game1(MainWindow mw)
        {
            players = new List<Player>();
            mainWnd = mw;
            InitializeComponent();
            initializeServer();
        }

        void initializeServer()
        {
            foreach (UIElement playerGrid in MainGrid.Children)
            {
                players.Add(new Player((Grid)playerGrid));
            }
            foreach (Player item in players)
            {
                if (item == players.First())
                {
                    item.IsWaiting = false;
                    item.RootGrid.IsEnabled = true;
                }
                else
                {
                    item.IsWaiting = true;
                    item.RootGrid.IsEnabled = false;
                }
            }
            scores = new int[players.Count];
        }

        public List<Player> Clients
        {
            get
            {
                return players;
            }

            set
            {
                players = value;
            }
        }

        public Player CurrentClient
        {
            get
            {
                foreach (Player p in players)
                {
                    if (p.IsWaiting == false)
                    {
                        return p;
                    }
                }
                return null;
            }
        }

        public bool Check(Player currentClient)
        {
            return false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWnd.Show();
        }

        public void MakeMove()
        {
            bool changed = false;

            foreach (Player pl in players)
            {
                if (pl.IsWaiting == false)
                {
                    if (pl == players.Last())
                    {
                        pl.RootGrid.IsEnabled = false;
                        pl.IsWaiting = true;
                        players.First().IsWaiting = false;
                        players.First().RootGrid.IsEnabled = true;
                        changed = false;
                    }
                    else
                    {
                        pl.RootGrid.IsEnabled = false;
                        pl.IsWaiting = true;
                        changed = true;
                    }
                    continue;
                }
                if (changed)
                {
                    pl.RootGrid.IsEnabled = true;
                    pl.IsWaiting = false;
                    changed = false;
                }
            }
        }

        public void Sync(Player owner, string word)
        {
            foreach (Player player in players)
            {
                if (owner != player)
                {
                    player.RootGrid.Children.OfType<Label>().Where(t => t.Tag as string == "city_lbl").FirstOrDefault().Content = word;
                    player.RootGrid.Children.OfType<TextBox>().Where(t => t.Tag as string == "city_input").FirstOrDefault().Text = "";
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            GameButtonClick();
        }

        private void Enter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GameButtonClick();
            }
        }

        void GameButtonClick()
        {
            Button SendBtn = CurrentClient.RootGrid.Children.OfType<Button>().FirstOrDefault();
            TextBox inputTB = CurrentClient.RootGrid.Children.OfType<TextBox>().Where(t => t.Tag as string == "city_input").FirstOrDefault();
            inputTB.BorderBrush = Brushes.Gray;

            if (inputTB.Text.Length == 0 || inputTB.Text == "")
            {
                inputTB.BorderBrush = Brushes.Red;
                return;
            }

            if (words.Count == 0)
            {
                words.Add(inputTB.Text);
                Sync(CurrentClient, inputTB.Text);
            }
            else
            {
                string lastWord = words.Last();

                //if (lastWord[lastWord.Length - 1] != 'ь' || lastWord[lastWord.Length - 1] != 'ъ' || lastWord[lastWord.Length - 1] != 'ы' || lastWord[lastWord.Length - 1] != 'й')
                //{ }

                if (inputTB.Text[0].ToString().ToLower() == lastWord[lastWord.Count() - 1].ToString().ToLower())
                {
                    words.Add(inputTB.Text);
                    Sync(CurrentClient, inputTB.Text);
                }
                else
                {
                    inputTB.BorderBrush = Brushes.Red;
                    return;
                }

            }

            inputTB.BorderBrush = Brushes.Green;
            CurrentClient.Scores += inputTB.Text.Count();
            CurrentClient.RootGrid.Children.OfType<Label>().Where(t => t.Tag as string == "scores_lbl").FirstOrDefault().Content = CurrentClient.Scores.ToString();

            MakeMove();
        }
    }
}
