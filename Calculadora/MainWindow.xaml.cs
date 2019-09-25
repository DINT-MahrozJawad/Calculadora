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
            PorDefecto();
        }
        private void PorDefecto()
        {
            Operando1.Text = "0";
            Operando2.Text = "0";
            Resultado.Text = "0";
            Suma.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (Suma.IsChecked == true)
            {
                if (Operando1.Text != "" && Operando2.Text != "" && !double.TryParse(Operando1.Text, out double r))
                    Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) + double.Parse(Operando2.Text), 2).ToString()}";
            }
            else if (Resta.IsChecked == true)
            {
                if (Operando1.Text != "" && Operando2.Text != "")
                    Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) - double.Parse(Operando2.Text), 2).ToString()}";
            }
            else if (Multiplicacion.IsChecked == true)
            {
                if (Operando1.Text != "" && Operando2.Text != "")
                    Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) * double.Parse(Operando2.Text), 2).ToString()}";
            }
            else if (Division.IsChecked == true)
            {
                if (Operando1.Text != "" && Operando2.Text != "" && Operando2.Text != "0")
                    Resultado.Text = $"{Math.Round((double.Parse(Operando1.Text) / double.Parse(Operando2.Text)), 2).ToString()}";
                else
                    Resultado.Text = "Error";
            }
        }

        private void Operando_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calcular();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PorDefecto();
        }
    }
}
