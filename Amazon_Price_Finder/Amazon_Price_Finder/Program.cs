using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Diagnostics;
using AmazonPriceFinderForm;

// Doxygen
// http://www.stack.nl/~dimitri/doxygen/docblocks.html
//! This is the namespace for the application
/**
 * All of the classes and methods reside within this namespace.
 */
namespace Amazon_Price_Finder
{
    //! The main class of the program
    /**
     * This is the class that is run on entry into the application.
     */
    class AmazonPriceFinder
    {
        //! The main method of the program
        /**
         * This is the method that is run on entry into the application
         */
        static void Main()
        {
            double price;
            AmazonPriceFinderForm.FormAmazonPrice form = new AmazonPriceFinderForm.FormAmazonPrice();
            DataTable set = Database_Conn.getDBResults();
            set.Columns.Add("GooglePrice", typeof(double));

            foreach (DataRow row in set.Rows)
            {
                price = GooglePrices.getPrice(row["IDNumber"].ToString());
                row["GooglePrice"] = Math.Round(price, 2);
            }

            form.ShowDialog();  
        }
    }
}