using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Project
{
    class DataAccessCustomers
    {
        public static void InitializeCustomersDatabase()
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customers " +
                    "(Customer_Id NVARCHAR(10) PRIMARY KEY, " +
                    "Customer_Name NVARCHAR(50) NOT NULL," +
                    "Address NVARCHAR(50) NOT NULL," +
                    "Email NVARCHAR(50) NOT NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
        }           // Create table




        public static void AddData(string customer_ID, string CustomerName, string CustomerAddress, string CustomerEmail)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Customers VALUES (@customer_ID, @CustomerName, @CustomerAddress, @CustomerEmail);";
                insertCommand.Parameters.AddWithValue("@customer_ID", customer_ID);
                insertCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
                insertCommand.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                insertCommand.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Add new Customers




        public static ArrayList CheckCustomerID()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }    // Check Customer ID




        public static ArrayList GetData()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add("ID : " + query.GetString(0));
                    entries.Add("Name : " + query.GetString(1));
                    entries.Add("Address : " + query.GetString(2) );
                    entries.Add("Email : " + query.GetString(3) + "\n");
                }

                db.Close();
            }

            return entries;
        }     // get all data 



        public static ArrayList GetDataCustomer(string customer_ID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers where Customer_Id = '" + customer_ID + "'", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add("ID : " + query.GetString(0));
                    entries.Add("Name : " + query.GetString(1));
                    entries.Add("Address : " + query.GetString(2));
                    entries.Add("Email : " + query.GetString(3) + "\n");
                }

                db.Close();
            }

            return entries;
        }     // get data from customerID


        public static void DeleteCustomerData(string customer_ID)
        {
            using(SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open(); 


                String removeCommand = "delete from Customers where Customer_Id = '" + customer_ID + "' ";

                SqliteCommand removeData = new SqliteCommand(removeCommand, db); 

                removeData.ExecuteReader();

                db.Close();
            }
        }




        public static ArrayList GetCustomerID(string CustomerID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers where Customer_Id = '" + CustomerID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }    // get Customer ID where ID



        public static ArrayList GetCustomerName(string CustomerID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers where Customer_Id = '" + CustomerID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(1));
                }

                db.Close();
            }

            return entries;
        }    // get Customer Name where ID


        public static ArrayList GetCustomerAddress(string CustomerID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers where Customer_Id = '" + CustomerID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(2));
                }

                db.Close();
            }

            return entries;
        }    // get Customer Address where ID



        public static ArrayList GetCustomerEmail(string CustomerID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT Customer_Id, Customer_Name, Address, Email from Customers where Customer_Id = '" + CustomerID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(3));
                }

                db.Close();
            }

            return entries;
        }    // get Customer Email where ID




        public static void UpdateData(string customer_ID, string CustomerName, string CustomerAddress, string CustomerEmail)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "UPDATE Customers SET Customer_Id = @customer_ID, Customer_Name = @CustomerName, Address = @CustomerAddress, Email = @CustomerEmail  where Customer_Id = '" + customer_ID + "';";
                insertCommand.Parameters.AddWithValue("@customer_ID", customer_ID);
                insertCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
                insertCommand.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                insertCommand.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Update Customer data
    }
}
