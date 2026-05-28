using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;


namespace WinFormsApp2.Data
{
    public static class DbConnectionFactory
    {
        private const string ConnectionString = "Data Source=clinic.db";

        public static SqliteConnection Create()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}