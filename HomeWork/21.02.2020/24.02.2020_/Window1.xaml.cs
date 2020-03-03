using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _24._02._2020_
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DataClasses1DataContext c;
        public Window1(DataClasses1DataContext c)
        {
            InitializeComponent();
            this.c = c;
            TCreateBCreate.IsEnabled = false;
        }
        static string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
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
                    Password = GetHashString(TCreateTPassword.Text),
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

        private void TCreateTLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(c.Users.Where(q=>q.Login== TCreateTLogin.Text).Count()==0)
            {
                TCreateBCreate.IsEnabled = true;
            }
            else
            {
                TCreateBCreate.IsEnabled = false;
            }
        }
    }
}
