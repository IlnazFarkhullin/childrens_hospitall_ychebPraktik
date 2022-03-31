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
    /// Логика взаимодействия для Position.xaml
    /// </summary>
    public partial class Position : Page
    {
        public Position()
        {
            InitializeComponent();
            position.ItemsSource = BD.connect.conn.Position.ToList();
        }

        private void position_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void r_btn_Click(object sender, RoutedEventArgs e)
        {
            var b = position.SelectedItem as BD.Staff;
            if (b != null)
            {
                BD.connect.conn.Staff.Remove(b);
                BD.connect.conn.SaveChanges();
                position.ItemsSource = BD.connect.conn.Staff.ToList();


            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void a_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tools.regPosition());
        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage.AdminPage());
        }
    }
}
