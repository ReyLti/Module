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
using pr20._102k_LazarevD.Pages;
using pr20._102k_LazarevD.Entities;

namespace pr20._102k_LazarevD.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autho.xaml
    /// </summary>
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Password = tbPassword.Password.Trim();
            Users user = new Users();
            lazarevexamEntities lazarevexamEntities = new lazarevexamEntities();
            user = lazarevexamEntities.Users.Where(p => p.Name == Login).FirstOrDefault();
            int countUser = lazarevexamEntities.Users.Where(p => p.Name == Login).Count();
            if (countUser > 0)
            {
                MessageBox.Show("Вы вошли под "+user.Name);
                NavigationService.Navigate(new View());
            }
            else
            {
                MessageBox.Show("Не было найдено данного пользователя"); 
            }




        }
    }
}
