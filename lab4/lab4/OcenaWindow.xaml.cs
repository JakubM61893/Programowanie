using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab4
{
    /// <summary>
    /// Logika interakcji dla klasy OcenaWindow.xaml
    /// </summary>
    public partial class OcenaWindow : Window
    {
        public Student ocena;

        public OcenaWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                txbOcena.Text = ocena.ocena.ToString();
                
            }
            this.ocena = student ?? new Student();
        }
        public OcenaWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(txbOcena.Text, @"^[0-1]{2,5}$"))
            {
                MessageBox.Show("Podano błędne dane.");
                return;
            }
            

            this.DialogResult = true;
        }
    }
}
