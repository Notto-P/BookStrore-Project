using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Project
{
    class DataAccessUser
    {
        public static void InitializeUserDatabase()
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS userLogin " +
                    "(email NVARCHAR(100) PRIMARY KEY, " +
                    "password NVARCHAR(50) NOT NULL," +
                    "firstName NVARCHAR(50) NOT NULL," +
                    "lastName NVARCHAR(50) NOT NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
        }           // Create table



        public static void AddData(string email, string password, string firstname, string lastname)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO userLogin VALUES (@email, @password, @firstname, @lastname);";
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@firstname", firstname);
                insertCommand.Parameters.AddWithValue("@lastname", lastname);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Add new user 





        public static void DeleteData(string email)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db")) 
            {
                db.Open();  


                String deleteCommand = "delete from userLogin where email = '" + email + "' ";

                SqliteCommand deleteData = new SqliteCommand(deleteCommand, db); 

                deleteData.ExecuteReader(); 

                db.Close();
            }
        }  //delete user data where Email






        public static ArrayList GetData()  
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT email, password, firstName, lastName from userLogin", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add("Email : " + query.GetString(0));
                    entries.Add("Password : " + query.GetString(1));
                    entries.Add(" Name : " + query.GetString(2) + "  " + query.GetString(3) + "\n");
                }

                db.Close();
            }

            return entries;
        }     // get all data 



        public static ArrayList CheckEmail()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT email, password, firstName, lastName from userLogin", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }    // get email




        public static ArrayList CheckPassword()
        {
            ArrayList entries = new ArrayList();

            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand selectcommand = new SqliteCommand("SELECT email, password, firstName, lastName from userLogin", db);
                SqliteDataReader query = selectcommand.ExecuteReader();


                while (query.Read())
                {
                    entries.Add(query.GetString(1));
                }

                db.Close();
            }

            return entries;
        }    // get password


    }
}
