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

namespace ChitChat.AppWindows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.Employee.FirstOrDefault(l => l.Username == TBUsername.Text);
            if (employee == null)
            {
                MessageBox.Show("Invalid login");
                return;
            }
            if (GetHash(employee.Password) != GetHash(PBPassword.Password))
            {
                MessageBox.Show("Invalid password");
                return;
            }
            this.Visibility = Visibility.Collapsed;
            new HelloWindow(employee).ShowDialog();
        }

        private string GetHash(string s)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            return Convert.ToBase64String(hash);
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
