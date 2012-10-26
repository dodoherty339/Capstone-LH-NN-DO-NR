using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            AmazonPriceFinderForm.FormAmazonPrice form = new AmazonPriceFinderForm.FormAmazonPrice();

            //AmazonRequest.SendRequest();
            double[] totals = new Double[] { 0.01, 100, 600, 700, 400, 500
                                           , 200, 300, 800 , 900 };
            AnalyzeResults.StartAnalyze(totals);

            form.ShowDialog();
        }
    }
}