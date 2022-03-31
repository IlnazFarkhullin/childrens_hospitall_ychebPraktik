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
    /// Логика взаимодействия для staff.xaml
    /// </summary>
    public partial class staff : Page
    {
        public staff()
        {
            InitializeComponent();

            liststaff.ItemsSource = BD.connect.conn.Staff.ToList();


        }

        private void liststaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tools.regStaff());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var b = liststaff.SelectedItem as BD.Staff;
            if (b != null)
            {
                BD.connect.conn.Staff.Remove(b);
                BD.connect.conn.SaveChanges();
                liststaff.ItemsSource =  BD.connect.conn.Staff.ToList();


            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage.AdminPage());
        }
    }
}
