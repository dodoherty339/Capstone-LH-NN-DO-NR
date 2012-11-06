﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Amazon_Price_Finder
{
    class Database_Conn
    {
        public static DataSet getDBResults()
        {
            //Create a new dataset object.
            DataSet set = new DataSet();
            //Create SqlConnection.
            using (SqlConnection conn = new SqlConnection())
            {
                //Connection string to connect to the database
                //Data Source is set to localhost
                //Initial Catalog is set to the database name
                conn.ConnectionString = "Integrated Security=SSPI; Data Source=localhost; Initial Catalog=ItemDB";
                using (SqlCommand cmd = new SqlCommand())
                {
                    //set the connection on the Sql Command object.
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * From Items";
                    using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                        adap.Fill(set);
                    }
                }
            }
            return set;
        }
    }
}
