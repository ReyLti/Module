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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        int ids;
        public Edit(int id)
        {
            InitializeComponent();
            tbName.Text = new lazarevexamEntities().Users.Find(id).Name;
            ids = id;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users user = new Users();
                user.Name = tbName.Text;
                user.IdUser = ids;
                lazarevexamEntities db = new lazarevexamEntities();
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Изменено");
                NavigationService.Navigate(new View());
            }
            catch
            {
                MessageBox.Show("Обязательные поля не были заполнены");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
