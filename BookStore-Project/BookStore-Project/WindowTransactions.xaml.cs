using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for WindowTransactions.xaml
    /// </summary>
    public partial class WindowTransactions : Window
    {
        public WindowTransactions()
        {
            InitializeComponent();

            DataAccessTransaction.InitializeTransactionsDatabase();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu windowMenu = new WindowMenu();
            windowMenu.Show();
            this.Close();
        }

        private void Tb_BookID_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (String.IsNullOrEmpty(tb_BookPrice.Text))                  
            {
                tb_TotalPrice.Clear();
            }

            ArrayList bookTitle = DataAccessBook.GetBookTitle(tb_BookID.Text);
            ArrayList bookDescription = DataAccessBook.GetBookDescription(tb_BookID.Text);
            ArrayList bookPrice = DataAccessBook.GetBookPrice(tb_BookID.Text);




            string dataTitle = "";
            foreach (string listTitle in bookTitle)
            {
                dataTitle = listTitle;
            }

            string dataDescription = "";
            foreach (string listDescription in bookDescription)
            {
                dataDescription = listDescription;
            }

            string dataPrice = "";
            foreach (string listPrice in bookPrice)
            {
                dataPrice = listPrice;
            }


                tb_BookTitle.Text = dataTitle;
                tb_BookDescription.Text = dataDescription;
                tb_BookPrice.Text = dataPrice;
            
        }

        private void Tb_BookQty_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_BookPrice.Text))                   //ถ้าในกล่องข้อความว่างเปล่า
            {
               
            }
            else if(String.IsNullOrEmpty(tb_BookQty.Text))
            {
                tb_TotalPrice.Clear();
            }
            else
            {
                double TotalPrice = 0;
                TotalPrice = double.Parse(tb_BookPrice.Text) * double.Parse(tb_BookQty.Text);
                tb_TotalPrice.Text = TotalPrice.ToString();
            }
        }





        private void Tb_BookQty_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);       // Input only Numbers 
        }






        private void Btn_btn_BookOrder_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_BookPrice.Text))                   //ถ้าในกล่องข้อความว่างเปล่า
            {
                MessageBox.Show("Please choose the book");
            }
            else if (String.IsNullOrEmpty(tb_BookQty.Text))
            {
                MessageBox.Show("Please insert the quantity");
            }
            else if(String.IsNullOrEmpty(tb_CustomerID.Text))
            {
                MessageBox.Show("Please insert CustomerID");
            }
            else
            {

                int keyCheck = 1;
                foreach (string list in DataAccessCustomers.CheckCustomerID())
                {
                    if (list == tb_CustomerID.Text)
                    {
                        keyCheck = 2;

                        if (MessageBox.Show("คุณต้องการซื้อหนังสือ : " + tb_BookTitle.Text + "\n" + "จำนวน = " + tb_BookQty.Text + " เล่ม ใช่หรือไม่?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {

                            DataAccessTransaction.AddData(tb_BookID.Text,tb_CustomerID.Text,tb_BookQty.Text,tb_TotalPrice.Text);

                            MessageBox.Show("ลูกค้ารหัส : " + tb_CustomerID.Text + "\n" + "ทำการซื้อหนังสือรหัส : " + tb_BookID.Text + ", ชื่อ : " + tb_BookTitle.Text + "\n" + "จำนวน : " + tb_BookQty.Text + " เล่ม" + "\n" + "ราคา : " + tb_TotalPrice.Text + " บาท", "สรุปรายการขาย");

                            tb_BookID.Clear();
                            tb_BookQty.Clear();
                            tb_TotalPrice.Clear();
                            tb_CustomerID.Clear();
                        }


                        break;
                    }
                }

                if (keyCheck == 1)
                {
                    MessageBox.Show("Customer ID : " + tb_CustomerID.Text + " not found");
                    tb_CustomerID.Clear();
                }

            }
        }
    }
}
