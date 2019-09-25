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

        private void RadioButton_Checked_Suma(object sender, RoutedEventArgs e)
        {
            if(Operando1.Text != "" && Operando2.Text != "")
                Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) - double.Parse(Operando2.Text), 2).ToString()}";
        }

        private void RadioButton_Checked_Resta(object sender, RoutedEventArgs e)
        {
            if (Operando1.Text != "" && Operando2.Text != "")
                Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) - double.Parse(Operando2.Text), 2).ToString()}";
        }

        private void RadioButton_Checked_Multiplicacion(object sender, RoutedEventArgs e)
        {
            if (Operando1.Text != "" && Operando2.Text != "")
                Resultado.Text = $"{Math.Round(double.Parse(Operando1.Text) * double.Parse(Operando2.Text),2).ToString()}";
        }

        private void RadioButton_Checked_Division(object sender, RoutedEventArgs e)
        {
            if (Operando1.Text != "" && Operando2.Text != "" && Operando2.Text != "0")
                Resultado.Text = $"{Math.Round((double.Parse(Operando1.Text) / double.Parse(Operando2.Text)),2).ToString()}";
            else
                Resultado.Text = "Error";
        }

        private void Operando_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Suma.IsChecked == true)
            {
                RadioButton_Checked_Suma(sender, e);
            }
            else if (Resta.IsChecked == true)
            {
                RadioButton_Checked_Resta(sender, e);
            }
            else if (Multiplicacion.IsChecked == true)
            {
                RadioButton_Checked_Multiplicacion(sender, e);
            }
            else if (Division.IsChecked == true)
            {
                RadioButton_Checked_Division(sender, e);
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PorDefecto();
        }
    }
}
