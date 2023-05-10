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
    /// Логика взаимодействия для ChatRoomWindow.xaml
    /// </summary>
    public partial class ChatRoomWindow : Window
    {
        EmployeeChatroom contextEmployeeChatroom;
        Employee contextEmployee;
        public ChatRoomWindow(EmployeeChatroom employeeChatroom, Employee employee)
        {
            InitializeComponent();
            contextEmployeeChatroom = employeeChatroom;
            DataContext = contextEmployeeChatroom;
            contextEmployee= employee;
            Refresh();
        }

        private void Refresh()
        {
            LVChatMessages.ItemsSource = App.DB.ChatMessage.Where(x=> x.Chatroom_Id == contextEmployeeChatroom.Chatroom_Id).ToList();
            LVEmployees.ItemsSource = App.DB.EmployeeChatroom.Where(x => x.Chatroom_Id == contextEmployeeChatroom.Chatroom_Id).ToList();
        }
        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new AddUserWindow(contextEmployeeChatroom,contextEmployee).ShowDialog();
        }

        private void BChangeTopic_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new HelloWindow(contextEmployee).ShowDialog();
        }

        private void BLeave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.EmployeeChatroom.Remove(contextEmployeeChatroom);
            App.DB.SaveChanges();
            this.DialogResult = true;
            new HelloWindow(contextEmployee).ShowDialog();
        }

        private void BSend_Click(object sender, RoutedEventArgs e)
        {
            var chatMessage = new ChatMessage() {Sender_Id = contextEmployeeChatroom.Employee.Id, Chatroom_Id = contextEmployeeChatroom.Chatroom_Id, Date=DateTime.Now, Message=TBMessage.Text};
            App.DB.ChatMessage.Add(chatMessage);
            App.DB.SaveChanges();
            Refresh();
            TBMessage.Text = "";
        }
    }
}
