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
        public HelloWindow()
        {
            InitializeComponent();
            DataContext = App.LoggedEmployee;
            Refresh();

        }
        private void Refresh()
        {
            DGChats.ItemsSource = App.DB.Chatroom.ToList().Where(c => c.EmployeeChatroom.Select(emp=> emp.Employee).Contains(App.LoggedEmployee)).ToList();
        }
        private void BEmployeeFinder_Click(object sender, RoutedEventArgs e)
        {
            new EmployeeFinderWindow(new Chatroom()).Show();
            this.Close();
        }

        private void BCloseApplication_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void DGChats_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var chatroom = DGChats.SelectedItem as Chatroom;
            if(chatroom == null)
            {
                MessageBox.Show("Select chatroom");
                return;
            }
            var result = new ChatRoomWindow(chatroom).ShowDialog();
            if (result.Value)
                Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
