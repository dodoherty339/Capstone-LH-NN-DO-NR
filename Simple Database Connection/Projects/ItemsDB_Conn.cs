using System;
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
            //Outputs AuditNum of second row
            Console.WriteLine("Retrieved an AuditNum id: {0}", set.Tables[0].Rows[1]["AuditNum"].ToString());
            //Outputs number of rows in the database
            Console.WriteLine("Retrieved {0} rows", set.Tables[0].Rows.Count);
            //waiting for input so we can view the output above
            Console.ReadLine();
        }
    }
}
