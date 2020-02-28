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

namespace _24._02._2020_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext c;
        public MainWindow()
        {
            InitializeComponent();
            c = new DataClasses1DataContext();
        }

        private void TCreateBCreate_Click(object sender, RoutedEventArgs e)
        {
            if (TCreateTLogin.Text != "" &&
                TCreateTPassword.Text != "" &&
                TCreateTAddress.Text != "" &&
                TCreateTPhone.Text != ""
                )
            {
                Users u = new Users
                {
                    Address = TCreateTAddress.Text,
                    Login = TCreateTLogin.Text,
                    Password = TCreateTPassword.Text,
                    Phone = TCreateTPhone.Text,
                    IsAdmin = (bool)TCreateTIsAdmin.IsChecked
                };
                c.Users.InsertOnSubmit(u);
                c.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Incorrect entered data");
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 0;
            Operation_Name.Text = "Create";
        }
        private void Read_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 1;
            Operation_Name.Text = "Read";
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 2;
            Operation_Name.Text = "Update";
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            TabCntrol_.SelectedIndex = 3;
            Operation_Name.Text = "Delete";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Load_ListBoxRead();
        }
        private void Load_ListBoxRead()
        {
            ListBoxRead.Items.Clear();
            foreach (var u in c.Users)
            {
                ListBoxRead.Items.Add(u.Id + " | " + u.Login + " | " + u.Password + " | " + u.Address + " | " + u.Phone + " | " + u.IsAdmin);
            }
        }
        private void UpdatedId_TextChanged(object sender, TextChangedEventArgs e)
        {
            int res;
            if (int.TryParse(UpdatedId.Text, out res))
            {
                Users u = c.Users.Where(q => q.Id == res).FirstOrDefault();
                if (u == null) return;
                TUpdateTLogin.Text = u.Login;
                TUpdateTPassword.Text = u.Password;
                TUpdateTAddress.Text = u.Address;
                TUpdateTPhone.Text = u.Phone;
                TUpdateTIsAdmin.IsChecked = u.IsAdmin;
            }
        }

        private void TUpdateBUpdate_Click(object sender, RoutedEventArgs e)
        {
            int res;
            if (int.TryParse(UpdatedId.Text, out res))
            {
                Users u = c.Users.Where(q => q.Id == res).FirstOrDefault();
                if (u == null) return;
                u.Login = TUpdateTLogin.Text;
                u.Password = TUpdateTPassword.Text;
                u.Address = TUpdateTAddress.Text;
                u.Phone = TUpdateTPhone.Text;
                u.IsAdmin = (bool)TUpdateTIsAdmin.IsChecked;
                c.SubmitChanges();
            }
        }

        private void TDeleteBDelete_Click(object sender, RoutedEventArgs e)
        {
            int res;
            if (int.TryParse(DeletedId.Text, out res))
            {
                Users u = c.Users.Where(q => q.Id == res).FirstOrDefault();
                if (u == null) return;
                c.Users.DeleteOnSubmit(u);
                c.SubmitChanges();
            }
        }

        private void DeletedId_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxDeletedElem.Items.Clear();
            int res;
            if (int.TryParse(DeletedId.Text, out res))
            {
                Users u = c.Users.Where(q => q.Id == res).FirstOrDefault();
                if (u == null) return;
                ListBoxDeletedElem.Items.Add(u.Id + " | " + u.Login + " | " + u.Password + " | " + u.Address + " | " + u.Phone + " | " + u.IsAdmin);
            }
        }
    }
}
