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
    /// Логика взаимодействия для ChangeTopicWindow.xaml
    /// </summary>
    public partial class ChangeTopicWindow : Window
    {
        Chatroom contextChatroom;
        Employee contextEmployee;
        public ChangeTopicWindow(Chatroom chatroom, Employee employee)
        {
            InitializeComponent();
            contextChatroom = chatroom;
            contextEmployee = employee;
            DataContext = contextChatroom;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if(contextChatroom.Id == 0)
            {
                App.DB.Chatroom.Add(contextChatroom);
                App.DB.EmployeeChatroom.Add(new EmployeeChatroom() { Chatroom_Id = contextChatroom.Id, Employee_Id = contextEmployee.Id });
                App.DB.EmployeeChatroom.Add(new EmployeeChatroom() { Chatroom_Id = contextChatroom.Id, Employee_Id = App.LoggedEmployee.Id });
                App.DB.SaveChanges();
                new ChatRoomWindow(contextChatroom).Show();
                this.Close();
            }
            else
            {
                App.DB.SaveChanges();
                this.DialogResult = true;

            }
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult= false;
        }
    }
}
