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

namespace MyHeladera
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" MyHeladerias 1.0 \n Creado por MarJo Systemas Informaticos");
        }

        private void Button_Click_Heladeria(object sender, RoutedEventArgs e)
        {
            Heladeria heladeria = new Heladeria();
            heladeria.Show();
        }

        private void Button_Click_Pedidos(object sender, RoutedEventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }

        private void Button_Click_Ventas(object sender, RoutedEventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void Button_Click_Salon(object sender, RoutedEventArgs e)
        {
            Salon salon = new Salon();
            salon.Show();
        }
    }
}
