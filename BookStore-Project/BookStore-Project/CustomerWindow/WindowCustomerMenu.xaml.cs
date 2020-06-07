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
    /// Interaction logic for WindowCustomerMenu.xaml
    /// </summary>
    public partial class WindowCustomerMenu : Window
    {
        public WindowCustomerMenu()
        {
            InitializeComponent();
            DataAccessCustomers.InitializeCustomersDatabase();
        }

        private void Btn_signout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerAdd windowCustomerAdd = new WindowCustomerAdd();
            windowCustomerAdd.Show();
            this.Close();
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerSearch windowCustomerSearch = new WindowCustomerSearch();
            windowCustomerSearch.Show();
            this.Close();
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerEdit windowCustomerEdit = new WindowCustomerEdit();
            windowCustomerEdit.Show();
            this.Close();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerDelete windowCustomerDelete = new WindowCustomerDelete();
            windowCustomerDelete.Show();
            this.Close();
        }

        private void Btn_back(object sender, RoutedEventArgs e)
        {
            WindowMenu windowMenu = new WindowMenu();
            windowMenu.Show();
            this.Close();
        }
    }
}
