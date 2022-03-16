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

namespace AplicacionconVariasPaginas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            frame1.Navigate(typeof(Login));
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(typeof(Login));
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(typeof(Acercade));
        }
    }
}
