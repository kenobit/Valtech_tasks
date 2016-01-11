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

namespace Multiplayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Server server = new Server();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Game1_Click(object sender, RoutedEventArgs e)
        {
            Game1 G1 = new Game1(this,server);
            G1.Show();
            this.Hide();
        }

        private void Game2_Click(object sender, RoutedEventArgs e)
        {
            Game1 G1 = new Game1(this, server);
            G1.Show();
            this.Hide();
        }

        private void Game3_Click(object sender, RoutedEventArgs e)
        {
            Game1 G1 = new Game1(this, server);
            G1.Show();
            this.Hide();
        }
    }
}
