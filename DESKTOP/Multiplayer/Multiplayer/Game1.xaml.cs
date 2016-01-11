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

namespace Multiplayer
{
    /// <summary>
    /// Interaction logic for Game1.xaml
    /// </summary>
    public partial class Game1 : Window
    {
        private MainWindow parentWND;
        private Server server;

        public Game1(MainWindow mainWND,Server server)
        {
            this.parentWND = mainWND;
            this.server = server;
            Player p1 = new Player("Vasya");
            Player p2 = new Player("Kolya");

            server.AddPlayer(p1);
            server.AddPlayer(p2);
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.parentWND.Show();
        }

        private void player1_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void player2_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
