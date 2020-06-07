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
    /// Interaction logic for WindowEditUser.xaml
    /// </summary>
    public partial class WindowEditUser : Window
    {
        public WindowEditUser()
        {
            InitializeComponent();
        }

        private void Btn_mainMenu_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu windowMenu = new WindowMenu();
            windowMenu.Show();
            this.Close();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_email.Text)) 
            {
                MessageBox.Show("Please input your 'EAMIL'");
            }
            else if(String.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("Please input your 'PASSWORD'");
            }
            else if(String.IsNullOrEmpty(tb_firstname.Text))
            {
                MessageBox.Show("Please input your 'FIRSTNAME'");
            }
            else if(String.IsNullOrEmpty(tb_lastname.Text))
            {
                MessageBox.Show("Please input your 'LASTNAME'");
            }
            else
            {
                int keyCheck = 1;
                foreach (string list in DataAccessUser.CheckEmail())
                {
                    if (list == tb_email.Text)
                    {
                        keyCheck = 2;
                        MessageBox.Show("This Eamil is already exist");
                        ClearDataInTextbox();
                        break;
                    }

                }

                if(keyCheck == 1)
                {
                    DataAccessUser.AddData(tb_email.Text, tb_password.Text, tb_firstname.Text, tb_lastname.Text);
                    MessageBox.Show("Add user complete");
                    ClearDataInTextbox();
                }

                
            }

            
            

            
        }


        private void ClearDataInTextbox()
        {
            tb_email.Clear();
            tb_firstname.Clear();
            tb_lastname.Clear();
            tb_password.Clear();
        }




         
        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_email.Text)) //ถ้าในกล่องข้อความว่างเปล่า
            {
                MessageBox.Show("Please input 'Email' to delete");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete" + tb_email.Text +  " ?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DataAccessUser.DeleteData(tb_email.Text);
                    MessageBox.Show("Delete user : " + tb_email.Text + " complete","Delete complete");
                    ClearDataInTextbox();
                }

            }



            

        }

        private void Btn_show_Click(object sender, RoutedEventArgs e)
        {
            //-----------------show all data in table----------------------------------------------
            string data = "";
            int counter = 0;
            foreach (string list in DataAccessUser.GetData())
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
    }
}
