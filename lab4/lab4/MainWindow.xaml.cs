using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

namespace lab4
{



    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public string wydzial { get; set; }
        public int ocena { get; set; }

        public Student(string imie, string nazwisko, int NrIndeksu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrIndeksu = NrIndeksu;
            this.wydzial = wydzial;
            this.ocena = ocena;
        }
        public Student()
           : this("", "", 0, "")
        { }




    }

    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }

        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){ imie = "Jan", nazwisko = "Kowalski", NrIndeksu = 1234, wydzial="KIS"},
                new Student(){ imie = "Anna", nazwisko = "Nowak", NrIndeksu = 4321, wydzial="KIS"},
                new Student(){ imie = "Michał", nazwisko = "Jacek", NrIndeksu = 34562, wydzial="KIS"}

            };

            
                InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imię") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nr indeksu", Binding = new Binding("NrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydzial", Binding = new Binding("wydzial") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Ocena", Binding = new Binding("ocena") });

            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
            dgStudent.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OcenaWindow();
            if (dialog.ShowDialog() == true)
            {
                
                dgStudent.Items.Refresh();
            }
        }
    }
    }

   

