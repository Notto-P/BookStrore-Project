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
    /// Interaction logic for WindowCustomerDelete.xaml
    /// </summary>
    public partial class WindowCustomerDelete : Window
    {
        public WindowCustomerDelete()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerMenu windowCustomerMenu = new WindowCustomerMenu();
            windowCustomerMenu.Show();
            this.Close();
        }

        private void Btn_show_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            int counter = 0;
            foreach (string list in DataAccessCustomers.GetData())
            {
                counter = counter + 1;
                data = data + list + "\n";
            }

            if (counter == 0)
            {
                MessageBox.Show("No member data found", "Member detail");
            }
            else
            {
                MessageBox.Show(data, "Member detail");
            }
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_CustomerID.Text)) 
            {
                MessageBox.Show("Please input CustomerID");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete CustomerID : " + tb_CustomerID.Text + " ?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DataAccessCustomers.DeleteCustomerData(tb_CustomerID.Text);
                    MessageBox.Show("Delete CustomerID : " + tb_CustomerID.Text + " complete", "Delete complete");
                    tb_CustomerID.Clear();
                }

            }
        }
    }
}
