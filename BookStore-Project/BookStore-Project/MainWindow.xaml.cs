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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStore_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccessUser.InitializeUserDatabase();
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_userName.Text))                  // Check empty box
            {
                MessageBox.Show("Please input 'Email' ");
            }
            else if (String.IsNullOrEmpty(pb_password.Password.ToString()))
            {
                MessageBox.Show("Please input 'Password' ");
            }
            else
            {
                int keyCheck = 1;
                foreach (string listEmail in DataAccessUser.CheckEmail())       //check email and password
                {
                    if (listEmail == tb_userName.Text)
                    {
                        foreach (string listPassword in DataAccessUser.CheckPassword())
                        {
                            if(listPassword == pb_password.Password.ToString())
                            {
                                WindowMenu windowMenu = new WindowMenu();
                                this.Close();    
                                windowMenu.Show();

                                keyCheck = 2;
                                break;
                            }
                        }
                    }
                    if(keyCheck == 2)
                    {
                        break;
                    }
                  
                }


                if(keyCheck == 1)
                {
                    MessageBox.Show("Email or Password is not correct");
                }

                pb_password.Clear();
                


            }


            
            //tb_userName.Foreground = Brushes.Red; //เปลี่ยนสี text
            
            
        }
    }
}
