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

namespace FlyingBall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
        void CreateCanvasWithEllipse(double desiredLeft, double desiredTop)
        {
            Canvas canvas = mainCanvas;
            Ellipse ellipse = new Ellipse(50,50,50,);
            Canvas.SetLeft(ellipse, desiredLeft);
            Canvas.SetTop(ellipse, desiredTop);
        }

    }
}
