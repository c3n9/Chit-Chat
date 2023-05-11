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
        Chatroom contextChatroom;
        public EmployeeFinderWindow(Chatroom chatroom)
        {
            InitializeComponent();
            contextChatroom = chatroom;
        }
        private void Refresh()
        {
            try
            {
                var filtred = App.DB.Employee.ToList();
                var searchText = TBSearch.Text.ToLower();
                if (!String.IsNullOrWhiteSpace(searchText))
                    filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText)).ToList();
                if(CBAdmin.IsChecked == false)
                    filtred = filtred.Where(f => f.department_id !=1).ToList();
                if (CBITHelpdesk.IsChecked == false)
                    filtred = filtred.Where(f => f.department_id != 2).ToList();
                if (CBEngineering.IsChecked == false)
                    filtred = filtred.Where(f => f.department_id != 3).ToList();
                if (CBSales.IsChecked == false)
                    filtred = filtred.Where(f => f.department_id != 4).ToList();
                if (CBMarketing.IsChecked == false)
                    filtred = filtred.Where(f => f.department_id != 5).ToList();
                LVEmployees.ItemsSource = filtred;
            }
            catch 
            {
            }
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
            new HelloWindow().Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void LVEmployees_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedEmployee = LVEmployees.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                MessageBox.Show("Select employee");
                return;
            }
            if(contextChatroom.Id == 0)
            {
                new ChangeTopicWindow(contextChatroom,selectedEmployee).ShowDialog();
                new HelloWindow().Show();
                this.Close();
            }
            else
            {
                var employeeChatroom = new EmployeeChatroom() { Employee_Id = selectedEmployee.Id, Chatroom_Id = contextChatroom.Id };
                App.DB.EmployeeChatroom.Add(employeeChatroom);
                App.DB.SaveChanges();
                this.DialogResult = true;
            }
        }
    }
}
