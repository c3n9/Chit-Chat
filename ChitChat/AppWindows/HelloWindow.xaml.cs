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
        Employee contextEmployee;
        public HelloWindow(Employee employee)
        {
            InitializeComponent();
            contextEmployee=employee;
            DataContext = contextEmployee;
            
        }
        private void Refresh()
        {
            DGChats.ItemsSource = App.DB.EmployeeChatroom.Where(x => x.Employee_Id == contextEmployee.Id).ToList();
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

        private void DGChats_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var employeeChatroom = DGChats.SelectedItem as EmployeeChatroom;
            if(employeeChatroom == null)
            {
                MessageBox.Show("Select chatroom");
                return;
            }
            new ChatRoomWindow(employeeChatroom).ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
