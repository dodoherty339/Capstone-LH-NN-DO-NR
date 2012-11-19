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
            //regular initialization
            //DataTable set = Database_Conn.getDBResults();

            //new initialization start
            DataTable set = new DataTable();
            DataRow setRow = set.NewRow();
            DataRow setRow1 = set.NewRow();
            DataRow setRow2 = set.NewRow();
            DataRow setRow3 = set.NewRow();
            set.Columns.Add("IDNumber", typeof(string));
            set.Columns.Add("ItemDesc", typeof(string));
            set.Columns.Add("Retail", typeof(double));

            setRow["IDNumber"] = "008888526841";
            setRow["ItemDesc"] = "Assassins Creed Revelations";
            setRow["Retail"] = "28.00";
            set.Rows.Add(setRow);
            setRow1["IDNumber"] = "047875842069";
            setRow1["ItemDesc"] = "Call Of Duty MW3";
            setRow1["Retail"] = "8.61";
            set.Rows.Add(setRow1);
            setRow2["IDNumber"] = "085391117018";
            setRow2["ItemDesc"] = "V for Vendetta";
            setRow2["Retail"] = "8.25";
            set.Rows.Add(setRow2);
            setRow3["IDNumber"] = "024543563969";
            setRow3["ItemDesc"] = "Office Space";
            setRow3["Retail"] = "8.61";
            set.Rows.Add(setRow3);
            //END OF MANUAL ADD

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