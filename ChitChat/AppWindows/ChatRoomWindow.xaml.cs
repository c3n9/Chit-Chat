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
        Chatroom contextChatroom;
        public ChatRoomWindow(Chatroom chatroom)
        {
            InitializeComponent();
            contextChatroom = chatroom;
            DataContext = contextChatroom;
            Refresh();
        }

        private void Refresh()
        {
            LVChatMessages.ItemsSource = App.DB.ChatMessage.Where(x=> x.Chatroom_Id == contextChatroom.Id).ToList();
            LVEmployees.ItemsSource = App.DB.EmployeeChatroom.Where(x => x.Chatroom_Id == contextChatroom.Id).Select(x => x.Employee).ToList();
            if(LVChatMessages.ItemsSource != null)
            {
                var lastItem = LVChatMessages.ItemsSource.Cast<Object>().LastOrDefault();
                LVChatMessages.ScrollIntoView(lastItem);
            }
        }
        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            var result = new EmployeeFinderWindow(contextChatroom).ShowDialog();
            if (result.Value)
                Refresh();
        }

        private void BChangeTopic_Click(object sender, RoutedEventArgs e)
        {
            var result = new ChangeTopicWindow(contextChatroom, App.LoggedEmployee).ShowDialog();
            if(result.Value) 
                Refresh();
        }

        private void BLeave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.EmployeeChatroom.Remove(contextChatroom.EmployeeChatroom.FirstOrDefault(x => x.Employee_Id == App.LoggedEmployee.Id));
            App.DB.SaveChanges();
            this.DialogResult = true;
        }

        private void BSend_Click(object sender, RoutedEventArgs e)
        {
            var chatMessage = new ChatMessage() {Sender_Id = App.LoggedEmployee.Id, Chatroom_Id = contextChatroom.Id, Date=DateTime.Now, Message=TBMessage.Text};
            App.DB.ChatMessage.Add(chatMessage);
            App.DB.SaveChanges();
            Refresh();
            TBMessage.Text = String.Empty;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BCLose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
