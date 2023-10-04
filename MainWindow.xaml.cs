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

namespace Tema2_CuadroTexto
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

        private void Nombre_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                nombre_TextBlock.Text = "Nombre del cliente";
        }

        private void Apellido_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                apellido_TextBlock.Text = "Apellido del cliente";
        }

        private void Edad_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (!int.TryParse(edad_TextBox.Text, out _))
                {
                    edad_TextBlock.Foreground = Brushes.Red;
                    edad_TextBlock.Text = "Entrada incorrecta";
                }
                else
                    edad_TextBlock.Text = "";
            }
        }
    }
}
