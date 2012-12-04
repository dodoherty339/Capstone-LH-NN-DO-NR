using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Price_Comparison
{
    //! The class for connecting to the database.
    /**
     * This class contains methods that connect to and communicate with the
     * database.
     */
    class Database_Conn
    {
        //! This is the method that calls and reads from the database.
        /**
         * When the method is called it initially creates a new datatable called 
         * set and a sql connection string called conn. The connection string 
         * is used to gain access to the database in which we want to use. Next
         * we create a new Sqlcommand object called cmd. We then set the 
         * connection on the sql command object and then create the command 
         * text, or select command for the sql database. We apply the command 
         * to our table and fill our datatable object (set) with all of the 
         * info from the table. After all of it is in our object we return the 
         * datatable.
         */
        public static DataTable getDBResults()
        {
            //Create a new dataset object.
            DataTable set = new DataTable();
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
