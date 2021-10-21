using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial_2
{
    class Connection
    {
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=parcial;Uid=root;" +
                "Pwd=usbw;SSL Mode=None");
        public MySqlCommand command;


        public MySqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }


        public MySqlConnection closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }

    }
}
   
