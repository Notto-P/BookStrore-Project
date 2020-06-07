using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Project
{
    class DataAccessBook
    {

        public static void InitializeBookDatabase()
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Book " +
                    "(ISBN NVARCHAR(10) PRIMARY KEY, " +
                    "Title NVARCHAR(50) NOT NULL," +
                    "Description NVARCHAR(100) NOT NULL," +
                    "Price DOUBLE NOT NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
        }           // Create table




        public static void AddData(string BookID, string BookTitle, string BookDescription, string BookPrice)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Book VALUES (@BookID, @BookTitle, @BookDescription, @BookPrice);";
                insertCommand.Parameters.AddWithValue("@BookID", BookID);
                insertCommand.Parameters.AddWithValue("@BookTitle", BookTitle);
                insertCommand.Parameters.AddWithValue("@BookDescription", BookDescription);
                insertCommand.Parameters.AddWithValue("@BookPrice", BookPrice);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Add new Book




        public static ArrayList CheckBookID()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }    // Check Customer ID


        public static ArrayList GetDataBook(string bookID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book where ISBN = '" + bookID + "'", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add("ISBN : " + query.GetString(0));
                    entries.Add("Title : " + query.GetString(1));
                    entries.Add("Description : " + query.GetString(2));
                    entries.Add("Price : " + query.GetString(3) + "\n");
                }

                db.Close();
            }

            return entries;
        }     // get data from BookID




        public static ArrayList GetData()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add("ISBN : " + query.GetString(0));
                    entries.Add("Title : " + query.GetString(1));
                    entries.Add("Description : " + query.GetString(2));
                    entries.Add("Price : " + query.GetString(3) + "\n");
                }

                db.Close();
            }

            return entries;
        }     // get all data 





        public static void DeleteBookData(string bookID)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();


                String removeCommand = "delete from Book where ISBN = '" + bookID + "' ";

                SqliteCommand removeData = new SqliteCommand(removeCommand, db);

                removeData.ExecuteReader();

                db.Close();
            }
        } // delete book data



        public static ArrayList GetBookID(string BookID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book where ISBN = '" + BookID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }    // get Book ID where ID



        public static ArrayList GetBookTitle(string BookID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book where ISBN = '" + BookID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(1));
                }

                db.Close();
            }

            return entries;
        }    // get Book title where ID


        public static ArrayList GetBookDescription(string BookID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book where ISBN = '" + BookID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(2));
                }

                db.Close();
            }

            return entries;
        }    // get Book description where ID


        public static ArrayList GetBookPrice(string BookID)
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT ISBN, Title, Description, Price from Book where ISBN = '" + BookID + "' ", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(3));
                }

                db.Close();
            }

            return entries;
        }    // get Book price where ID


        public static void UpdateData(string BookID, string BookTitle, string BookDescription, string BookPrice)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "UPDATE Book SET ISBN = @BookID, Title = @BookTitle, Description = @BookDescription, Price = @BookPrice  where ISBN = '" + BookID + "';";
                insertCommand.Parameters.AddWithValue("@BookID", BookID);
                insertCommand.Parameters.AddWithValue("@BookTitle", BookTitle);
                insertCommand.Parameters.AddWithValue("@BookDescription", BookDescription);
                insertCommand.Parameters.AddWithValue("@BookPrice", BookPrice);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Update Book data


    }
}
