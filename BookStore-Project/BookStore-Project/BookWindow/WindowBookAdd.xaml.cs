using System;
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
    /// Interaction logic for WindowBppkAdd.xaml
    /// </summary>
    public partial class WindowBookAdd : Window
    {
        public WindowBookAdd()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowBookMenu windowBookMenu = new WindowBookMenu();
            windowBookMenu.Show();
            this.Close();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_BookID.Text))                   //ถ้าในกล่องข้อความว่างเปล่า
            {
                MessageBox.Show("Please input 'ISBN' ");
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
                int keyCheck = 1;
                foreach (string list in DataAccessBook.CheckBookID())
                {
                    if (list == tb_BookID.Text)
                    {

                        keyCheck = 2;
                        MessageBox.Show("ID : " + list + " already exist");
                        break;
                    }
                }

                if (keyCheck == 1)
                {
                    DataAccessBook.AddData(tb_BookID.Text, tb_BookTitle.Text, tb_BookDescription.Text, tb_BookPrice.Text);
                    MessageBox.Show("added ID " + tb_BookID.Text + " done");
                    tb_BookID.Clear();
                    tb_BookTitle.Clear();
                    tb_BookDescription.Clear();
                    tb_BookPrice.Clear();
                }

                
            }
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            tb_BookID.Clear();
            tb_BookTitle.Clear();
            tb_BookDescription.Clear();
            tb_BookPrice.Clear();
        }

        private void Tb_BookPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
