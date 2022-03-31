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

namespace childrens_hospitall.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для PatientPage2.xaml
    /// </summary>
    public partial class PatientPage2 : Page
    {
        public PatientPage2()
        {
            InitializeComponent();
            patient.ItemsSource = BD.connect.conn.Patient.ToList();
        }

        private void patient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate( new tools.regPatient());
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
              var b = patient.SelectedItem as BD.Patient;
            if (b != null)
            {
                BD.connect.conn.Patient.Remove(b);
                BD.connect.conn.SaveChanges();
                patient.ItemsSource =  BD.connect.conn.Patient.ToList();


            }
            else 
            { 
                MessageBox.Show("Такой записи нет"); 
            }
        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new zavfiz.zavfizPage  ());
        }
    }
}
