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

namespace childrens_hospitall.tools
{
    /// <summary>
    /// Логика взаимодействия для regPatient.xaml
    /// </summary>
    public partial class regPatient : Page
    {
        public regPatient()
        {
            InitializeComponent();
            CombClass.ItemsSource = BD.connect.conn.Branches.ToList();
            CombClass1.ItemsSource = BD.connect.conn.Ward.ToList();
            CombClass2.ItemsSource = BD.connect.conn.Staff.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
           
            BD.Patient clients = new BD.Patient() { sname  = txt_sname.Text, name = txt_name.Text, patronymic = txt_lastname.Text, hp =birthday.SelectedDate, age =Convert.ToInt32 (txt_age.Text), diagnosis = txt_diagnozc.Text,id_branches=((BD.Branches)CombClass.SelectedItem).id_branches , id_ward=((BD.Ward)CombClass1.SelectedItem).id_ward, id_staff=((BD.Staff)CombClass2.SelectedItem).id_staff };
            BD.connect.conn.Patient.Add(clients);
            BD.connect.conn.SaveChanges();
            MessageBox.Show($"Сотрудник:\n {txt_sname.Text} {txt_name.Text} {txt_lastname.Text} зарегестрирован", "info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.PatientPage2());
        }
    }
}
