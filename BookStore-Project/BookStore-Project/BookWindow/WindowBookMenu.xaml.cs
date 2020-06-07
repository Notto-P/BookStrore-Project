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
    /// Interaction logic for WindowBookMenu.xaml
    /// </summary>
    public partial class WindowBookMenu : Window
    {
        public WindowBookMenu()
        {
            InitializeComponent();

            DataAccessBook.InitializeBookDatabase();
        }

        private void Btn_signout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Btn_back(object sender, RoutedEventArgs e)
        {
            WindowMenu windowMenu = new WindowMenu();
            windowMenu.Show();
            this.Close();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            WindowBookAdd windowBookAdd = new WindowBookAdd();
            windowBookAdd.Show();
            this.Close();
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            WindowBookSearch windowBookSearch = new WindowBookSearch();
            windowBookSearch.Show();
            this.Close();
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            WindowBookEdit windowBookEdit = new WindowBookEdit();
            windowBookEdit.Show();
            this.Close();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            WindowBookDelete windowBookDelete = new WindowBookDelete();
            windowBookDelete.Show();
            this.Close();
        }
    }
}
