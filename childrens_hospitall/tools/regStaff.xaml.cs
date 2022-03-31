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
    /// Логика взаимодействия для regStaff.xaml
    /// </summary>
    public partial class regStaff : Page
    {
        public regStaff()
        {
            InitializeComponent();
            CombClass.ItemsSource = BD.connect.conn.Position.ToList();
           
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

            var b = CombClass.SelectedItem as BD.Position;
            var a = BD.connect.conn.Staff.Where(z => z.id_position == b.id_position).FirstOrDefault();
            BD.Staff clients = new BD.Staff() { fname = txt_sname.Text, name = txt_name.Text, patronymic = txt_lastname.Text, speciality =txt_spes.Text, name_speciality = txt_name_spes.Text, name_kvalivication = txt_kvalic.Text, id_position = a.id_position };
            BD.connect.conn.Staff.Add(clients);
            BD.connect.conn.SaveChanges();
            MessageBox.Show($"Сотрудник:\n {txt_sname.Text} {txt_name.Text} {txt_lastname.Text} зарегестрирован", "info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.staff());
        }
    }
}
