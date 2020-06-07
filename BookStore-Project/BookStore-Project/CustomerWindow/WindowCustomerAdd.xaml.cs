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
    /// Interaction logic for WindowCustomer.xaml
    /// </summary>
    public partial class WindowCustomerAdd : Window
    {
        public WindowCustomerAdd()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerMenu windowCustomerMenu = new WindowCustomerMenu();
            windowCustomerMenu.Show();
            this.Close();
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            tb_CustomerAddress.Clear();
            tb_CustomerEmail.Clear();
            tb_CustomerName.Clear();
            tb_CustomerID.Clear();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_CustomerID.Text))                   //ถ้าในกล่องข้อความว่างเปล่า
            {
                MessageBox.Show("Please input 'Customer ID' ");
            }
            else if (String.IsNullOrEmpty(tb_CustomerName.Text))
            {
                MessageBox.Show("Please input 'Name' ");
            }
            else if (String.IsNullOrEmpty(tb_CustomerAddress.Text))
            {
                MessageBox.Show("Please input 'Address' ");
            }
            else if(String.IsNullOrEmpty(tb_CustomerEmail.Text))
            {
                MessageBox.Show("Please input 'Email' ");
            }
            else
            {

                int keyCheck = 1;
                foreach (string list in DataAccessCustomers.CheckCustomerID())
                {
                    if (list == tb_CustomerID.Text)
                    {

                        keyCheck = 2;
                        MessageBox.Show("ID : " + list + " already exist");
                        break;
                    }
                }

                if (keyCheck == 1)
                {
                    DataAccessCustomers.AddData(tb_CustomerID.Text, tb_CustomerName.Text, tb_CustomerAddress.Text, tb_CustomerEmail.Text);
                    MessageBox.Show("added ID " + tb_CustomerID.Text + " done");
                    tb_CustomerAddress.Clear();
                    tb_CustomerEmail.Clear();
                    tb_CustomerName.Clear();
                    tb_CustomerID.Clear();
                }
            }
        }
    }
}
