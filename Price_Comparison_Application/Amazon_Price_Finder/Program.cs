using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows;

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
        public static DataTable set = new DataTable(); /*!< this is the set of all records read from the database */
        public static int totalPages; /*!< this is the total number of pages the list takes up based on the number of records per page */
        public static int currPage = 0; /*!< this is the currently displayed page of the list */
        public static int numResultsPerPage = 25; /*!< this is how many results to display per page */
        public static int totalItemsInSet = 0; /*!< this is the total number of records in the set */
        public static int totalRecordsToDisplay = 0; /*!< this is the number of records to display based on barcode verification */
        public static PriceComparisonForm.FormPriceCompare form; /*!< this is the form for the application */
        public static SplashForm splash; /*!< this is the form used as a splash screen */
        public static DataRow[] sortedRows; /*!< this is an array of the records in sorted order */
        public static String sortCol = "dbPrice, barcode"; /*!< this is the parameter for the sort function */
        public static String filter = "1 = 1"; /*!< this is the parameter for the filter function */
        public static int firstRecord; /*!< this is the number of the first record on the screen */
        public static int lastRecord; /*!< this is the number of the last record on the screen */

        //! The main method of the program
        /**
         * This is the method that is run on entry into the application
         */
        static void Main()
        {
            double price;
            form = new PriceComparisonForm.FormPriceCompare();
            splash = new SplashForm();
            splash.Show();
            splash.lblProgress.Text = "Loading online prices...";
            splash.Update();

            // Define the format of the set.
            PriceComparison.set.Columns.Add("Barcode", typeof(String));
            PriceComparison.set.Columns.Add("Dscr", typeof(String));
            PriceComparison.set.Columns.Add("dbPrice", typeof(double));
            PriceComparison.set.Columns.Add("onlinePrice", typeof(double));
            PriceComparison.set.Columns.Add("diff", typeof(double));

            //obtain hardcoded data
            DisplayResultsTable.createSet();

            //obtain data from database
            //DataTable set = Database_Conn.getDBResults();

            totalItemsInSet = set.Rows.Count;

            foreach (DataRow row in set.Rows)
            {
                // if row contains an item that is not used 
                // or does not have the correct barcode format, 
                // do not search
                price = GooglePrices.getPrice(row["Barcode"].ToString(), row["Dscr"].ToString());
                row["onlinePrice"] = Math.Round(price, 2);
                if (price != 0)
                {
                    row["diff"] = Math.Round(price - (Double)row["dbPrice"], 2);
                }
                totalRecordsToDisplay++;
                splash.lblProgress.Text = "Loading online prices... " + totalRecordsToDisplay.ToString() + " of " + totalItemsInSet.ToString();
                splash.Update();
            }

            DisplayResultsTable.displayTable();
            
            splash.Close();
            form.ShowDialog();
        }
    }
}