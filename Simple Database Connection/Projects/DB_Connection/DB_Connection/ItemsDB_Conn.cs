﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DB_Connection
{
    class ItemsDB_Conn
    {
        static void Main(string[] args)
        {
            string barcode = "008888526841";
            //Create a new dataset object.
            DataSet set = new DataSet();
            string[] arr = new string[3];
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
            foreach (DataRow row in set.Tables[0].Rows)
            {
                //found in database
                if (row["IDNumber"].ToString() == barcode)
                {
                    //assign each value to a spot in an array
                    arr[0] = row["IDNumber"].ToString();
                    arr[1] = row["ItemDesc"].ToString();
                    arr[2] = row["Retail"].ToString();
                    
                    //print each spot to make sure its correct
                    foreach (string str in arr)
                    {
                        Console.WriteLine("{0}", str);
                    }
                        //return arr;
                }
            }
            //Outputs AuditNum of third row Item Description
            //Console.WriteLine("Retrieved an AuditNum id: {0}", set.Tables[0].Rows[2]["ItemDesc"].ToString());
            //Outputs AuditNum of third row IDNumber
            //Console.WriteLine("Retrieved an AuditNum id: {0}", set.Tables[0].Rows[2]["IDNumber"].ToString());
            //Outputs number of rows in the database
            //Console.WriteLine("Retrieved {0} rows", set.Tables[0].Rows.Count);

            //waiting for input so we can view the output above
            Console.ReadLine();
        }
    }
}