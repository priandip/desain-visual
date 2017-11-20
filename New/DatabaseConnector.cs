using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace New
{
    class DatabaseConnector
    {
        public MySqlConnection Connection;

        public DatabaseConnector()
        {
            string server = "localhost";
            string database = "arsip_surat";
            string uid = "root";
            string password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

           Connection = new MySqlConnection(connectionString);
        }
    }
}
