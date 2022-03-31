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

namespace childrens_hospitall.zavfiz
{
    /// <summary>
    /// Логика взаимодействия для zavfizPage.xaml
    /// </summary>
    public partial class zavfizPage : Page
    {
        public zavfizPage()
        {
            InitializeComponent();
        }

        private void patient_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewFolder1.PatientPage2());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new authorization.Page1());
        }
    }
}
