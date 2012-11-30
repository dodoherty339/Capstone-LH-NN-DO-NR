using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Diagnostics;
using System.ComponentModel;

// Doxygen
// http://www.stack.nl/~dimitri/doxygen/docblocks.html
//! This is the namespace for the application
/**
 * All of the classes and methods reside within this namespace.
 */
namespace Price_Comparison
{
    //! The main class of the program
    /**
     * This is the class that is run on entry into the application.
     */
    class PriceComparison
    {
        public static DataTable set = new DataTable();
        public static int totalPages;
        public static int currPage = 0;
        public static int numResultsPerPage = 25;
        public static int totalRecords = 0;
        public static PriceComparisonForm.FormPriceCompare form;
        public static SplashScreen splash;
        //public static SplashSc
        public static DataRow[] sortedRows;
        public static String sortCol = "dbPrice";
        public static String filter = "1 = 1";
        public static int firstRecord;
        public static int lastRecord;

        //! The main method of the program
        /**
         * This is the method that is run on entry into the application
         */
        static void Main()
        {
            double price;
            form = new PriceComparisonForm.FormPriceCompare();
            splash = new SplashScreen();
            splash.Show();
            
            //obtain data from database
            //DataTable set = Database_Conn.getDBResults();

            //obtain hardcoded data
            DisplayResultsTable.createSet();

            foreach (DataRow row in set.Rows)
            {
                price = GooglePrices.getPrice(row["Barcode"].ToString());
                row["onlinePrice"] = Math.Round(price, 2);
                row["diff"] = Math.Round(price - (Double)row["dbPrice"], 2);
                totalRecords++;
            }

            DisplayResultsTable.displayTable();

            splash.Close();
            form.ShowDialog();
        }
    }
}