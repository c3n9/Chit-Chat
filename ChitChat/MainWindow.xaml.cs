using ChitChat.AppWindows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChitChat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string GetHash(string s)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            return Convert.ToBase64String(hash);
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
            App.LoggedEmployee = employee;
            new HelloWindow().Show();
            this.Close();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }

}
