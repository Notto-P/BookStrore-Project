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
    /// Interaction logic for WindowBookSearch.xaml
    /// </summary>
    public partial class WindowBookSearch : Window
    {
        public WindowBookSearch()
        {
            InitializeComponent();
        }

        private void Btn_show_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            int counter = 0;
            foreach (string list in DataAccessBook.GetData())
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

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowBookMenu windowBookMenu = new WindowBookMenu();
            windowBookMenu.Show();
            this.Close();
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_BookID.Text))
            {
                MessageBox.Show("Please input 'BookID' ");
            }
            else
            {
                ArrayList arrayList = DataAccessBook.GetDataBook(tb_BookID.Text);
                string data = "";
                int counter = 0;
                foreach (string list in arrayList)
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


                tb_BookID.Clear();
            }
        }
    }
}
