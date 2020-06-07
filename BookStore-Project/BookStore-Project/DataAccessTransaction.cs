using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Project
{
    class DataAccessTransaction
    {
        public static void InitializeTransactionsDatabase()
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Transactions " +
                    "(ISBN NVARCHAR(10) NOT NULL, " +
                    "CustomerID NVARCHAR(50) NOT NULL," +
                    "Quatity INTEGER NOT NULL," +
                    "TotalPrice DOUBLE NOT NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                createTable.ExecuteReader();
            }
        }           // Create table



        public static void AddData(string BookID, string CustomerID, string BookQty, string TotalPrice)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename=sqliteBookStore.db"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Transactions VALUES (@BookID, @CustomerID, @BookQty, @TotalPrice);";
                insertCommand.Parameters.AddWithValue("@BookID", BookID);
                insertCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                insertCommand.Parameters.AddWithValue("@BookQty", BookQty);
                insertCommand.Parameters.AddWithValue("@TotalPrice", TotalPrice);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }       // Add new TR
    }
}
