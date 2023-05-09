using ChitChat.Model;
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
using System.Windows.Shapes;

namespace ChitChat.AppWindows
{
    /// <summary>
    /// Логика взаимодействия для HelloWindow.xaml
    /// </summary>
    public partial class HelloWindow : Window
    {
        public HelloWindow(Employee employee)
        {
            InitializeComponent();
            DataContext = employee;
        }

        private void BEmployeeFinder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new EmployeeFinderWindow().ShowDialog();
        }

        private void BCloseApplication_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
