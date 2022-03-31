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
    /// Логика взаимодействия для regPosition.xaml
    /// </summary>
    public partial class regPosition : Page
    {
        public regPosition()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tools.regPosition());
        }
    }
}
