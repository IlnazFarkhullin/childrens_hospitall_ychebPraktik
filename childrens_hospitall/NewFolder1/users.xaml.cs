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
    /// Логика взаимодействия для users.xaml
    /// </summary>
    public partial class users : Page
    {
        public users()
        {
            InitializeComponent();
            //var a = BD.connect.conn.login_data.Where(z => z.id_login_date == ActualData.Id_User).FirstOrDefault();
            DGrid.ItemsSource =  BD.connect.conn.user.ToList();
        }

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage.AdminPage());
        }
    }
}
