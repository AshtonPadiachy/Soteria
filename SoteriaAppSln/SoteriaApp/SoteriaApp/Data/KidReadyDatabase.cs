using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoteriaApp.Data
{
    public class KidReadyDatabase
    {
        private SQLiteConnection Database;
        public  string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath,"KidReadyDatabase");
            }
        }
        public KidReadyDatabase()
        {
            Database = new SQLiteConnection(DatabasePath, SQLite.SQLiteOpenFlags.ReadWrite |
                // create the database if it doesn't exist
                SQLite.SQLiteOpenFlags.Create |
                // enable multi-threaded database access
                SQLite.SQLiteOpenFlags.SharedCache
);
           // Database.CreateTable
        }


    }
}
