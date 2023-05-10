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
        public AddUserWindow(EmployeeChatroom employeeChatroom)
        {
            InitializeComponent();
            contextEmployeeChatroom = employeeChatroom;
            CBEmployee.ItemsSource = App.DB.EmployeeChatroom.Where(x=> x.Chatroom_Id == contextEmployeeChatroom.Chatroom_Id).ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
