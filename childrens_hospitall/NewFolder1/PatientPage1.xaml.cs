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
    /// Логика взаимодействия для PatientPage1.xaml
    /// </summary>
    public partial class PatientPage1 : Page
    {
        public PatientPage1()
        {
            InitializeComponent();
            patient.ItemsSource = BD.connect.conn.Patient.ToList();
        }

        private void patient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Glavvrach.GlavvrachPage());
        }       
    }
}
