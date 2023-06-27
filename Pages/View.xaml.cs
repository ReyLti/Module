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
    /// Логика взаимодействия для View.xaml
    /// </summary>
    public partial class View : Page
    {
        public View()
        {
            InitializeComponent();
            dgMain.ItemsSource = new lazarevexamEntities().Users.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add());        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Users user = dgMain.SelectedItem as Users;
            if (user != null)
            {
                NavigationService.Navigate(new Edit(user.IdUser));
            }
            else
            {
                MessageBox.Show("Не был выбран пользователь");
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Users user = dgMain.SelectedItem as Users;
            if(user != null)
            {
                lazarevexamEntities lazarevexamEntities = new lazarevexamEntities();
                lazarevexamEntities.Users.Remove(lazarevexamEntities.Users.Find(user.IdUser));
                lazarevexamEntities.SaveChanges();
                dgMain.ItemsSource = lazarevexamEntities.Users.ToList();
                MessageBox.Show("Запись удалена");
            }
            else
            {
                MessageBox.Show("Запись не была выбрана");
            }
        }

    }
}
