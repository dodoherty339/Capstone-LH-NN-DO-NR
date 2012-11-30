using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace Price_Comparison
{
    class DisplayResultsTable
    {
        public static void UpdateDatabase(int index)
        {
            Price_Comparison.PriceComparison.form.tblResults["DatabasePrice", index].Value 
                = Regex.Replace(Price_Comparison.PriceComparison.form.tblResults["DatabasePrice", index].Value.ToString()
                               , @"[^\d\.]", "");
            DataRow row 
                = Price_Comparison.PriceComparison.set.Select("Barcode = " + Price_Comparison.PriceComparison.form.tblResults["Barcode", index].Value.ToString())[0];
            Console.WriteLine(row["Barcode"] + ", " + row["Dscr"] + ", " + row["dbPrice"] + ", " + row["onlinePrice"]);
            row["dbPrice"] = Price_Comparison.PriceComparison.form.tblResults["DatabasePrice", index].Value;
            row["diff"] = (Double)row["onlinePrice"] - (Double)row["dbPrice"];
            Console.WriteLine(row["Barcode"] + ", " + row["Dscr"] + ", " + row["dbPrice"] + ", " + row["onlinePrice"]);
            //displayRow(index, row);
            displayTable();
        }

        public static void createSet()
        {
            Price_Comparison.PriceComparison.set.Columns.Add("Barcode", typeof(String));
            Price_Comparison.PriceComparison.set.Columns.Add("Dscr", typeof(String));
            Price_Comparison.PriceComparison.set.Columns.Add("dbPrice", typeof(double));
            Price_Comparison.PriceComparison.set.Columns.Add("onlinePrice", typeof(double));
            Price_Comparison.PriceComparison.set.Columns.Add("diff", typeof(double));
            Price_Comparison.PriceComparison.set.Rows.Add("008888526841", "Assassins Creed Revelations", 28, 0, 0);
            Price_Comparison.PriceComparison.set.Rows.Add("047875842069", "Call Of Duty MW3", 8.61, 0, 0);
            Price_Comparison.PriceComparison.set.Rows.Add("085391117018", "V for Vendetta", 8.25, 0, 0);
            Price_Comparison.PriceComparison.set.Rows.Add("024543563969", "Office Space", 8.61, 0, 0);
        }

        public static void displayTable()
        {
            Price_Comparison.PriceComparison.sortedRows = sortFilterRows();
            Price_Comparison.PriceComparison.totalRecords = Price_Comparison.PriceComparison.sortedRows.Length;
            setFirstLastRecord();
            int count = 0;
            Price_Comparison.PriceComparison.form.tblResults.Rows.Clear();
            if (Price_Comparison.PriceComparison.sortedRows.Length > 0)
            {
                for (int i = Price_Comparison.PriceComparison.firstRecord; i < Price_Comparison.PriceComparison.lastRecord && i < Price_Comparison.PriceComparison.totalRecords; i++)
                {
                    Price_Comparison.PriceComparison.form.tblResults.Rows.Add();
                    displayRow(count, Price_Comparison.PriceComparison.sortedRows[i]);
                    count++;
                }
            }
            else
            {
                Price_Comparison.PriceComparison.form.tblResults.Rows.Add();
                Price_Comparison.PriceComparison.form.tblResults["Description", 0].Value = "The current filter contains no records.";
            }
        }

        public static void displayRow(int rowNum, DataRow row)
        {
            Price_Comparison.PriceComparison.form.tblResults["Barcode", rowNum].Value = row["Barcode"].ToString();
            Price_Comparison.PriceComparison.form.tblResults["Description", rowNum].Value = row["Dscr"].ToString();
            Price_Comparison.PriceComparison.form.tblResults["DatabasePrice", rowNum].Value = "$" + row["dbPrice"].ToString();
            Price_Comparison.PriceComparison.form.tblResults["OnlinePrice", rowNum].Value = "$" + row["onlinePrice"].ToString();
            if ((Double)row["diff"] < 0)
            {
                Price_Comparison.PriceComparison.form.tblResults["Difference", rowNum].Value = row["diff"].ToString();
                Price_Comparison.PriceComparison.form.tblResults["Difference", rowNum].Style.BackColor = System.Drawing.Color.OrangeRed;
            }
            if ((Double)row["diff"] > 0)
            {
                Price_Comparison.PriceComparison.form.tblResults["Difference", rowNum].Value = "+" + row["diff"].ToString();
                Price_Comparison.PriceComparison.form.tblResults["Difference", rowNum].Style.BackColor = System.Drawing.Color.GreenYellow;
            }
        }

        public static DataRow[] sortFilterRows()
        {
            return Price_Comparison.PriceComparison.set.Select(Price_Comparison.PriceComparison.filter, Price_Comparison.PriceComparison.sortCol);
        }

        public static void setFirstLastRecord()
        {
            Price_Comparison.PriceComparison.firstRecord = Price_Comparison.PriceComparison.currPage * Price_Comparison.PriceComparison.numResultsPerPage;
            Price_Comparison.PriceComparison.lastRecord = Price_Comparison.PriceComparison.firstRecord + Price_Comparison.PriceComparison.numResultsPerPage - 1;
        }
    }
}
