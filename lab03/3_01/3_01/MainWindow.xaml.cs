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

namespace _3_01
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

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(txba.Text);
                float b = float.Parse(txbb.Text);
                txbWynik.Text = ("Suma " + a + " + " + b + " = " + (a + b)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButton.OK);
            }
        }

        private void btnRoznica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(txba.Text);
                float b = float.Parse(txbb.Text);
                txbWynik.Text = ("Różnica " + a + " - " + b + " = " + (a - b)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButton.OK);
            }
        }

        private void btnIloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a = float.Parse(txba.Text);
                float b = float.Parse(txbb.Text);
                txbWynik.Text = ("Iloczyn " + a + " * " + b + " = " + (a * b)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButton.OK);
            }
        }

        private void btnIloraz_Click(object sender, RoutedEventArgs e)
        {
            float a = float.Parse(txba.Text);
            float b = float.Parse(txbb.Text);
            if (b != 0)
            try
            {
                txbWynik.Text = ("Iloraz " + a + " / " + b + " = " + (a / b)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButton.OK);
            }
            if (b == 0)
            {
                txbWynik.Text = "nie dziel przez 0";
                MessageBox.Show("nie dziel przez 0", "Uwaga!", MessageBoxButton.OK);
            }
        }
    }
}
