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

namespace childrens_hospitall.Branch
{
    /// <summary>
    /// Логика взаимодействия для BranchPage.xaml
    /// </summary>
    public partial class BranchPage : Page
    {
        public BranchPage()
        {
            InitializeComponent();
           branch.ItemsSource = BD.connect.conn.Branches.ToList();
        }

        private void branch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remove_button_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void Back_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Glavvrach.GlavvrachPage());
        }

        private void branch2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
