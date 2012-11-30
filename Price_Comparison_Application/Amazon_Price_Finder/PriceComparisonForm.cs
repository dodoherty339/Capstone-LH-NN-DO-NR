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
    public partial class FormPriceCompare : Form
    {
        public FormPriceCompare()
        {
            InitializeComponent();
        }

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

        private void radBtnPriceLow_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "dbPrice";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnPriceHigh_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "dbPrice DESC";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnDiffNeg_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "diff";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnDiffPos_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.sortCol = "diff DESC";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnMore_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "onlinePrice > dbPrice";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnLess_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "onlinePrice < dbPrice";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtnNone_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.filter = "1 = 1";
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtn25_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 25;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtn50_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 50;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void radBtn100_CheckedChanged(object sender, EventArgs e)
        {
            Price_Comparison.PriceComparison.numResultsPerPage = 100;
            Price_Comparison.PriceComparison.currPage = 0;
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Price_Comparison.PriceComparison.currPage > 0)
            {
                Price_Comparison.PriceComparison.currPage--;
            }
            Price_Comparison.DisplayResultsTable.displayTable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Price_Comparison.PriceComparison.currPage < Price_Comparison.PriceComparison.totalPages)
            {
                Price_Comparison.PriceComparison.currPage++;
            }
            Price_Comparison.DisplayResultsTable.displayTable();
        }
    }
}
