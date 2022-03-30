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

namespace MyHeladera
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    public partial class Ventas : Window
    {
        public Ventas()
        {
            InitializeComponent();
        }
        public int contador = 0;
        private void marcos_Click(object sender, RoutedEventArgs e)
        {
           
            contador++;
            texto.Text = contador.ToString();
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            contador = 0;
            ima.Visibility=Visibility.Visible;
        }

        private void ima_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ima.Visibility = Visibility.Hidden;
        }
    }
}
