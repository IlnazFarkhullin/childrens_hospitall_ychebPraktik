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

namespace childrens_hospitall.Glavvrach
{
    /// <summary>
    /// Логика взаимодействия для GlavvrachPage.xaml
    /// </summary>
    public partial class GlavvrachPage : Page
    {
        public GlavvrachPage()
        {
            InitializeComponent();
        }

        private void staff_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.Staff2());
        }

        private void branch_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.Branch1());
        }

        private void Bdck_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new authorization.Page1());
        }

        private void patient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.PatientPage1());
        }
    }
}
