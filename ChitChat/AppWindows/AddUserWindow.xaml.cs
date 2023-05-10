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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        EmployeeChatroom contextEmployeeChatroom;
        Employee contextEmployee;
        public AddUserWindow(EmployeeChatroom employeeChatroom, Employee employee)
        {
            InitializeComponent();
            contextEmployeeChatroom = employeeChatroom;
            contextEmployee = employee;
            CBEmployee.ItemsSource = App.DB.Employee.ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            var employee = CBEmployee.SelectedItem as Employee;
            var employeeChatroom = new EmployeeChatroom() { Employee_Id=employee.Id, Chatroom_Id= contextEmployeeChatroom.Chatroom_Id};
            App.DB.EmployeeChatroom.Add(employeeChatroom);
            App.DB.SaveChanges();
            this.Close();
            new ChatRoomWindow(contextEmployeeChatroom,contextEmployee).ShowDialog();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new ChatRoomWindow(contextEmployeeChatroom, contextEmployee).ShowDialog();
        }
    }
}
