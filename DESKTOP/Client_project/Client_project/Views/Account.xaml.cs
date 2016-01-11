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

namespace Client_project.Views
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }
        
        public int ClientConnector
        {
            get { return (int)GetValue(ClientConnectorProperty); }
            set { SetValue(ClientConnectorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClientConnector.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClientConnectorProperty =
            DependencyProperty.Register("ClientConnector", typeof(int), typeof(Account), new PropertyMetadata(0));


    }
}
