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

namespace WpfApp2

{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int NrIndeksu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrIndeksu = NrIndeksu;
            this.wydzial = wydzial;

        }
        public Student()
           : this("", "", 0, "")
        { }




    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
