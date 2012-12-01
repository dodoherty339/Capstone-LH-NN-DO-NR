using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriceComparisonForm
{
    //! The form class
    /**
     * This is the class for the application's main form.
     */
    public partial class FormPriceCompare : Form
    {
        //! A constructor.
        /**
         * This is the constructor for the form.
         */
        public FormPriceCompare()
        {
            InitializeComponent();
        }

        //! This is the method that updates the database price.
        /**
         * This method is called when "Cell Edit" ends, which occurs either when 
         * either the enter key or esc key are pressed in edit mode.  The only
         * cell that can be edited is the "Database Price" cell.
         * 
         * The method checks whether the barcode is null, indicating there are no 
         * records, and if it isn't, it calls the UpdateDatabase() method.  If 
         * there are no records, the field is reset to an empty string.
         */
        private void tblResults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (tblResults["Barcode", e.RowIndex].Value != null)
            {
                Price_Comparison.DisplayResultsTable.UpdateDatabase(e.RowIndex);
            }
            else
            {
                tblResults["DatabasePrice", e.RowIndex].Value = "";
            }
        }

        //! This is the method called when the "Price (low to high)" radio button is selected.
        /**
         * This method changes the sort parameter to "dbPrice, barcode" 
         * indicating sorting by the database price, ascending, and then by 
         * barcode.  It returns to the first page of the list and displays the 
         * table.
         */
        private void radBtnPriceLow_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "dbPrice, barcode";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Price (high to low)" radio button is selected.
        /**
         * This method changes the sort parameter to "dbPrice DESC, barcode" 
         * indicating sorting by the database price, descending, and then by 
         * barcode.  It returns to the first page of the list and displays the 
         * table.
         */
        private void radBtnPriceHigh_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "dbPrice DESC, barcode";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Difference (negative to positive)" radio button is selected.
        /**
         * This method changes the sort parameter to "diff, barcode" indicating
         * sorting by the difference and displaying the most negative numbers 
         * first and the most positive numbers last, and then by barcode.  It 
         * returns to the first page of the list and displays the table.
         */
        private void radBtnDiffNeg_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "diff, barcode";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Difference (positive to negative)" radio button is selected.
        /**
         * This method changes the sort parameter to "diff DESC, barcode" 
         * indicating sorting by the difference and displaying the most 
         * positive numbers first and the most negative numbers last, and then 
         * by barcode.  It returns to the first page of the list and displays 
         * the table.
         */
        private void radBtnDiffPos_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "diff DESC, barcode";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Items more expensive online" radio button is selected.
        /**
         * This method changes the filter parameter to "onlinePrice > dbPrice" 
         * indicating that only records where the online price is greater than
         * the database price should be displayed.  It returns to the first page 
         * of the list and displays the table.
         */ 
        private void radBtnMore_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "onlinePrice > dbPrice";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Items less expensive online" radio button is selected.
        /**
         * This method changes the filter parameter to 
         * "onlinePrice < dbPrice and onlinePrice <> 0" indicating that 
         * only records where the online price is less than the database price 
         * and the online price is not 0 should be displayed.  It returns to 
         * the first page of the list and displays the table.
         */ 
        private void radBtnLess_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "onlinePrice < dbPrice and onlinePrice <> 0";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Items with online prices" radio button is selected.
        /**
         * This method changes the filter parameter to "onlinePrice <> 0" 
         * indicating that only records where the online price is not 0 should
         * be displayed.  It returns to the first page of the list and 
         * displays the table.
         */
        private void radBtnOnlinePrices_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "onlinePrice <> 0";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "No filter" radio button is selected.
        /**
         * This method changes the filter parameter to "1 = 1" which always 
         * evaluates to true, indicating that all records should be displayed.  
         * It returns to the first page of the list and displays the table.
         */
        private void radBtnNone_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "1 = 1";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "25 per screen" radio button is selected.
        /**
         * This method changes number of results per page to 25.  It returns 
         * to the first page of the list and displays the table.
         */
        private void radBtn25_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 25;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "50 per screen" radio button is selected.
        /**
         * This method changes number of results per page to 50.  It returns 
         * to the first page of the list and displays the table.
         */
        private void radBtn50_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 50;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "100 per screen" radio button is selected.
        /**
         * This method changes number of results per page to 100.  It returns 
         * to the first page of the list and displays the table.
         */
        private void radBtn100_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 100;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        //! This is the method called when the "Previous" button is clicked.
        /**
         * This method checks if the current page is 0 or the first page of the
         * list.  If it is not, it decrements the current page by one then it 
         * displays the table.
         */
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Price_Comparison.PriceComparison.currPage > 0)
            {
                Price_Comparison.PriceComparison.currPage--;
                Price_Comparison.DisplayResultsTable.displayTable();
            }
        }

        //! This is the method called when the "Next" button is clicked.
        /**
         * This method checks if the current page is the last page of the
         * list.  If it is not, it increments the current page by one then it 
         * displays the table.
         */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Price_Comparison.PriceComparison.currPage < Price_Comparison.PriceComparison.totalPages)
            {
                Price_Comparison.PriceComparison.currPage++;
                Price_Comparison.DisplayResultsTable.displayTable();
            }
        }
    }
}
