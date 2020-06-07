using System;
using System.Collections;
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
    /// Interaction logic for WindowCustomerEdit.xaml
    /// </summary>
    public partial class WindowCustomerEdit : Window
    {
        public WindowCustomerEdit()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowCustomerMenu windowCustomerMenu = new WindowCustomerMenu();
            windowCustomerMenu.Show();
            this.Close();
        }

        private void Btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            tb_CustomerAddress.Clear();
            tb_CustomerEmail.Clear();
            tb_CustomerName.Clear();
            tb_CustomerID.Clear();
            tb_find.Clear();
        }

        private void Btn_find_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_find.Text))                   
            {
                MessageBox.Show("Please input 'Customer ID' ");
            }
            else
            {
                ArrayList customerID = DataAccessCustomers.GetCustomerID(tb_find.Text);
                ArrayList customerName = DataAccessCustomers.GetCustomerName(tb_find.Text);
                ArrayList customerAddress = DataAccessCustomers.GetCustomerAddress(tb_find.Text);
                ArrayList customerEmail = DataAccessCustomers.GetCustomerEmail(tb_find.Text);


                string dataID = "";
                int counter = 0;
                foreach (string listID in customerID)
                {
                    counter = counter + 1;
                    dataID = listID;
                }

                string dataName = "";
                foreach (string listName in customerName)
                {
                    dataName = listName;
                }

                string dataAddress = "";
                foreach (string listAddress in customerAddress)
                {
                    dataAddress = listAddress;
                }

                string dataEamil = "";
                foreach (string listEmail in customerEmail)
                {
                    dataEamil = listEmail;
                }


                if (counter == 0)
                {
                    MessageBox.Show("No member data found", "Member detail");
                }
                else
                {
                    tb_CustomerID.Text = dataID;
                    tb_CustomerName.Text = dataName;
                    tb_CustomerAddress.Text = dataAddress;
                    tb_CustomerEmail.Text = dataEamil;
                }
            }

            
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
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
            else if (String.IsNullOrEmpty(tb_CustomerEmail.Text))
            {
                MessageBox.Show("Please input 'Email' ");
            }
            else
            {
                if (MessageBox.Show("Do you want to save changing ?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DataAccessCustomers.UpdateData(tb_CustomerID.Text, tb_CustomerName.Text, tb_CustomerAddress.Text, tb_CustomerEmail.Text);
                    MessageBox.Show("Update completed !!");

                    tb_CustomerAddress.Clear();
                    tb_CustomerEmail.Clear();
                    tb_CustomerName.Clear();
                    tb_CustomerID.Clear();
                }

                
            }
        }
    }
}
