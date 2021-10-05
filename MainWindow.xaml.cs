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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = MensajeNombre;
            ApellidoTextBox.Tag = MensajeApellido;
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
               MensajeNombre.Visibility = Visibility.Visible;
            }
            else
            {
                MensajeNombre.Visibility = Visibility.Hidden;
            }
        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                MensajeNombre.Visibility = Visibility.Visible;
            }
            else
            {
                MensajeNombre.Visibility = Visibility.Hidden;
            }
        }
    }
}
