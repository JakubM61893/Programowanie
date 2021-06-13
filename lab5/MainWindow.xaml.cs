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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

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
            
        }
        public Student()
           : this("", "", 0, "")
        { }




    }
    public class Budynek
    {
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

       

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "data"; 
            dlg.DefaultExt = ".txt"; 
            dlg.Filter = "data (.txt)|*.txt"; 

            
            Nullable<bool> result = dlg.ShowDialog();

            
            if (result == true)
            {
              
                string filename = dlg.FileName;
            }
            else
            {
                MessageBox.Show("Błąd!");
                return;
            }
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("[[Student]]");

            sw.Close();

            MessageBox.Show("Udało się!");
            return;
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "data";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "data (.txt)|*.txt";

            
            Nullable<bool> result = dlg.ShowDialog();

            
            if (result == true)
            {
                
                string filename = dlg.FileName;
            }
            else
            {
                MessageBox.Show("Błąd!");
                return;
            }

            FileStream fs = new FileStream("data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                var ln = sr.ReadLine();
            }

            sr.Close();
            MessageBox.Show("Udało się!");
            return;
        }
        void Save<T>(T ob, StreamWriter sw)
        {
            Type t = ob.GetType();
            sw.WriteLine($"[[{t.FullName}]]");
            foreach (var p in t.GetProperties())
            {
                sw.WriteLine($"[{p.Name}]");
                sw.WriteLine(p.GetValue(ob));
            }
            sw.WriteLine($"[[]]");
        }

        T Load<T>(StreamReader sr) where T : new()
        {
            T ob = default(T);
            Type tob = null;
            PropertyInfo property = null;

            while (!sr.EndOfStream)
            {
                var ln = sr.ReadLine();
                if (ln == "[[]]")
                    return ob;
                else if (ln.StartsWith("[["))
                {
                    tob = Type.GetType(ln.Trim('[', ']'));
                    if (typeof(T).IsAssignableFrom(tob))
                        ob = (T)Activator.CreateInstance(tob);
                }
                else if (ln.StartsWith("[") && ob != null)
                    property = tob.GetProperty(ln.Trim('[', ']'));
                else if (ob != null && property != null)
                    property.SetValue(ob, Convert.ChangeType(ln, property.PropertyType));
            }
            return default(T);
        }

        private void btnSXML_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "budynek";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "budynek (.xml)|*.xml";


            Nullable<bool> result = dlg.ShowDialog();


            if (result == true)
            {

                string filename = dlg.FileName;
            }
            else
            {
                MessageBox.Show("Błąd!");
                return;
            }

            Budynek b = new Budynek();
            FileStream fs = new FileStream("./budynek.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Budynek));
            serializer.Serialize(fs, b);
            fs.Close();
            MessageBox.Show("Udało się!");
            return;
        }

        private void btnLXML_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "budynek";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "budynek (.xml)|*.xml";


            Nullable<bool> result = dlg.ShowDialog();


            if (result == true)
            {

                string filename = dlg.FileName;
            }
            else
            {
                MessageBox.Show("Błąd!");
                return;
            }
            if (File.Exists("./budynek.xml"))
            {
                Budynek b;
                FileStream fs = new FileStream("./budynek.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Budynek));
                b = (Budynek)serializer.Deserialize(fs);
                fs.Close();
                MessageBox.Show("Udało się!");
                return;
            }
        }
    }

    
}

   

