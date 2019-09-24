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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando1.Text = "0";
            Operando2.Text = "0";
        }

        private void RadioButton_Checked_Suma(object sender, RoutedEventArgs e)
        {
            Resultado.Text = (double.Parse(Operando1.Text) + double.Parse(Operando2.Text)).ToString();
        }

        private void RadioButton_Checked_Resta(object sender, RoutedEventArgs e)
        {
            Resultado.Text = (double.Parse(Operando1.Text) - double.Parse(Operando2.Text)).ToString();
        }

        private void RadioButton_Checked_Multiplicacion(object sender, RoutedEventArgs e)
        {
            Resultado.Text = (double.Parse(Operando1.Text) * double.Parse(Operando2.Text)).ToString();
        }

        private void RadioButton_Checked_Division(object sender, RoutedEventArgs e)
        {
            if (Operando2.Text != "0")
                Resultado.Text = $"{(double.Parse(Operando1.Text) / double.Parse(Operando2.Text)).ToString()}:F2";
            else
                Resultado.Text = "Error";
        }

    }
}
