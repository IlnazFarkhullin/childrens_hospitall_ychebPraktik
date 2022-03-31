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
    /// Логика взаимодействия для Staff2.xaml
    /// </summary>
    public partial class Staff2 : Page
    {
        public Staff2()
        {
            InitializeComponent();
            liststaff.ItemsSource = BD.connect.conn.Staff.ToList();
        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Glavvrach.GlavvrachPage());
        }

        private void liststaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
