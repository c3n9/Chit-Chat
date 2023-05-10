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
    /// Логика взаимодействия для EmployeeFinderWindow.xaml
    /// </summary>
    public partial class EmployeeFinderWindow : Window
    {
        Employee contextEmployee;
        public EmployeeFinderWindow(Employee employee)
        {
            InitializeComponent();
            contextEmployee=employee;
            Refresh();
        }
        private void Refresh()
        {
            var filtred = App.DB.Employee.ToList();
            var searchText = TBSearch.Text.ToLower();
            if (!String.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText)).ToList();
            if (CBAdmin.IsChecked == true)
                filtred = filtred.Where(f => f.department_id == 1).ToList();
            if (CBITHelpdesk.IsChecked == true)
                filtred = filtred.Where(f => f.department_id == 2).ToList();
            if (CBEngineering.IsChecked == true)
                filtred = filtred.Where(f => f.department_id == 3).ToList();
            if (CBSales.IsChecked == true)
                filtred = filtred.Where(f => f.department_id == 4).ToList();
            if (CBMarketing.IsChecked == true)
                filtred = filtred.Where(f => f.department_id == 5).ToList();
            LVEmployees.ItemsSource = filtred;
        }

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BCLose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new HelloWindow(contextEmployee).ShowDialog();
        }
    }
}
