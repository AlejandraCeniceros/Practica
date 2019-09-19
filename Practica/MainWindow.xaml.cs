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

namespace Practica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Area1_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(BaseR.Text);
            double numero2 = int.Parse(AlturaR.Text);
            double resultado = numero1 * numero2;
            lblr1.Text = resultado.ToString();
        }

        private void BtnArea2_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(BaseTri.Text);
            double n2 = double.Parse(AlturaTri.Text);
            double resul = (n2 * n1) / 2;
            lblr2.Text = resul.ToString();

        }

        private void BtnArea3_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(Radio.Text);
            double resul = (num1 * 3.14159)* (num1 * 3.14159);
            lblr3.Text = resul.ToString();
        }

        private void BtnArea4_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(BMayorTra.Text);
            double n2 = double.Parse(BmenorTra.Text);
            double n3 = double.Parse(AlturaTra.Text);
            double resul = ((n2 + n1) / 2)*n3;
            lblr4.Text = resul.ToString();
        }
    }
}
