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

namespace BookStore_Project
{
    /// <summary>
    /// Interaction logic for WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void Btn_addUser_Click(object sender, RoutedEventArgs e)
        {
            WindowEditUser windowEditUser = new WindowEditUser();
            windowEditUser.Show();
            this.Close();
        }

        private void Btn_signout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Btn_customerDetail_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerMenu windowCustomerMenu = new WindowCustomerMenu();
            windowCustomerMenu.Show();
            this.Close();
        }

        private void Btn_booksDetail_Click(object sender, RoutedEventArgs e)
        {
            WindowBookMenu windowBookMenu = new WindowBookMenu();
            windowBookMenu.Show();
            this.Close();
        }

        private void Btn_booksOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowTransactions windowTransactions = new WindowTransactions();
            windowTransactions.Show();
            this.Close();
        }
    }
}
