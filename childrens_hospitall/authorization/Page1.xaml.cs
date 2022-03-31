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

namespace childrens_hospitall.authorization
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

            var a = BD.connect.conn.login_data .Where(z => z.login == txt_login.Text && z.passworsd == txt_password.Password).FirstOrDefault();
           

            if (a != null)
            {
                
                var b = a.user.FirstOrDefault();
                if (b.name == "Ильназ Алмазович")
                {
                    MessageBox.Show($"Добро пожаловать {b.name}  ", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new AdminPage.AdminPage());
                }
                else if (b.name == "Марат Тахирович")
                {
                    MessageBox.Show($"Добро пожаловать {b.name}  ", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new Glavvrach.GlavvrachPage());

                }
                else if (b.name == "Камиля Накиповна")
                {
                    MessageBox.Show($"Добро пожаловать {b.name}  ", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new zavfiz.zavfizPage());

                }
                else if (b.name == "Адиля Динаровна")
                {
                    MessageBox.Show($"Добро пожаловать {b.name}  ", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new zavlfk.zavlfk_Page());
                }
            }


            else
            {
                MessageBox.Show($"Логин или пароль не верный!", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }


                

                
            
        

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
