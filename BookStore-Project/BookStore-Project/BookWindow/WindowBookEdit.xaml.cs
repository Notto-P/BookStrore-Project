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
    /// Interaction logic for WindowBookEdit.xaml
    /// </summary>
    public partial class WindowBookEdit : Window
    {
        public WindowBookEdit()
        {
            InitializeComponent();
        }

        private void Btn_find_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_find.Text))
            {
                MessageBox.Show("Please input 'Book ID' ");
            }
            else
            {
                ArrayList bookID = DataAccessBook.GetBookID(tb_find.Text);
                ArrayList bookTitle = DataAccessBook.GetBookTitle(tb_find.Text);
                ArrayList bookDescription = DataAccessBook.GetBookDescription(tb_find.Text);
                ArrayList bookPrice = DataAccessBook.GetBookPrice(tb_find.Text);


                string dataID = "";
                int counter = 0;
                foreach (string listID in bookID)
                {
                    counter = counter + 1;
                    dataID = listID;
                }

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


                if (counter == 0)
                {
                    MessageBox.Show("No member data found", "Member detail");
                }
                else
                {
                    tb_BookID.Text = dataID;
                    tb_BookTitle.Text = dataTitle;
                    tb_BookDescription.Text = dataDescription;
                    tb_BookPrice.Text = dataPrice;
                }
            }
        }

        private void Btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            tb_BookDescription.Clear();
            tb_BookID.Clear();
            tb_BookTitle.Clear();
            tb_BookPrice.Clear();
            tb_find.Clear();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowBookMenu windowBookMenu = new WindowBookMenu();
            windowBookMenu.Show();
            this.Close();
        }

        private void Btn_edit_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_BookID.Text))                   //ถ้าในกล่องข้อความว่างเปล่า
            {
                MessageBox.Show("Please input 'book ID' ");
            }
            else if (String.IsNullOrEmpty(tb_BookTitle.Text))
            {
                MessageBox.Show("Please input 'Title' ");
            }
            else if (String.IsNullOrEmpty(tb_BookDescription.Text))
            {
                MessageBox.Show("Please input 'Description' ");
            }
            else if (String.IsNullOrEmpty(tb_BookPrice.Text))
            {
                MessageBox.Show("Please input 'Price' ");
            }
            else
            {
                if (MessageBox.Show("Do you want to save changing ?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DataAccessBook.UpdateData(tb_BookID.Text, tb_BookTitle.Text, tb_BookDescription.Text, tb_BookPrice.Text);
                    MessageBox.Show("Update completed !!");

                    tb_BookDescription.Clear();
                    tb_BookID.Clear();
                    tb_BookTitle.Clear();
                    tb_BookPrice.Clear();
                }


            }
        }
    }
}
