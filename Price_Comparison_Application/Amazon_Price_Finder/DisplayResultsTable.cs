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
            Price_Comparison.PriceComparison.set.Rows.Add("22512000019","MANGA Rurouni Kenshin Volume 6 BIG Edition",17.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("22512000026","DVD My Little Pony Friendship Is Magic",14.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20712000037","DVD Emma Victorian Romance Season Two",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20712000020","DVD E'S Otherwise Complete",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20712000013","DVD Excel Saga Complete",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20412000054","MANGA The Sigh of Haruhi Suzumiya",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20412000047","MANGA Bamboo Blade 10",11.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20412000030","MANGA Bamboo Blade 6",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20412000023","MANGA Sayonara Zetsubo Sensei 3",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20412000016","DVD Virus Complete Collection",39.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000010","MANGA Hyde and Closer 6",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000072","DVD Kenichi The Mighiest Disciple Season 1",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000034","DVD Gunslinger Girl Il Teatrino",59.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000065","MANGA Spiral Volume 3",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000058","MANGA Skip Beat 16",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000041","MANGA Skip Beat 25",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("4000501","DVD L/R Volume 2",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("4000556","DVD Nadia Nemo's Fortress",5.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000096","DVD Sekirei Season 1",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("4000510","DVD Tenchi in Tokyo A New Enemy",7.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000119","MANGA Train Man A Shojo Manga",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000140","MANGA Oresama Teacher 4",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000157","MANGA St Dragon Girl 8",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000164","MANGA Sgt Frog 15",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000188","MANGA Mao-Chan Volume 2",14.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000171","MANGA St Dragon Girl 4",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000201","DVD One Piece Season 1 Part 3",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000195","DVD One Piece Season 2 Part 1",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000218","MANGA Slam Dunk 18",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000225","MANGA YuGiOh! R 4",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("4000422","DVD Tenchi in Tokyo A New Love",7.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000270","MANGA Arisa 4",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000263","MANGA Slam Dunk 5",7.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000256","MANGA Slam Dunk 6",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000249","MANGA Slam Dunk 12",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000232","MANGA Slam Dunk 17",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000317","DVD Full Metal Panic Fumoffu",39.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000300","DVD Strike Witches Season 1",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000294","DVD Ikki Tousen Season 1",19.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000324","MANGA Oh My Goddess First End",14.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32312000331","MANGA Pokemon Adventures Diamond 3",7.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000026","DVD Xenosaga SAVE Edition",19.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000101","DVD Pani Poni Dash SAVE Edition",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000095","DVD Shuffle SAVE Edition",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000071","DVD Guyver SAVE Edition",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000064","DVD Speed Grapher SAVE Edition",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000057","DVD Initial D 2nd/3rd Stage",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000040","DVD Initial D Fourth Stage",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000033","DVD Initial D First Stage",29.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000118","MERCH Death Note Misa Body Pillow",44.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000125","MERCH InuYasha Kikyo Keychain",4.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000156","MERCH Naruto Shippuden Anti Stone Headband",21.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000149","MERCH Hetalia Germany and Italy Notebook",10.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000132","MERCH Code Geass Symbol Headband",11.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000163","MERCH Gravitation Suitcase PVC Keychain",4.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("699858938971","MERCH Trinity Blood Rosen Creuz Order Emblem",7.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000034","MERCH Trinity Blood Esther Metal Keychain",7.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000022","MERCH Trinity Blood AX Iron Maiden Icon Keychain",7.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000129","DVD I Shall Never Return",19.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000110","DVD Megazone 23",39.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000101","DVD Memories",19.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000066","DVD Cowboy Bebop Remix",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000059","DVD Gurren Lagann Complete",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000044","DVD Witch Hunter Robin Complete",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("6000097","DVD Petshop of Horrors",24.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000217","MANGA Bunny Drop Volume 5",12.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000200","MANGA 13th Boy Volume 11",11.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000194","MANGA Bamboo Blade Volume 12",11.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000187","MANGA Bride's Story Volume 3",16.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000224","MERCH Cheetah Ame-Comi Figure",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000286","MANGA Sailor V Volume 1",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000279","MANGA Sailor V Volume 2",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000262","MANGA Sailor Moon 1",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000255","MANGA Sailor Moon Volume 2",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000248","MANGA Sailor Moon Volume 3",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("32412000231","MANGA Sailor Moon Volume 4",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000010","DVD Linebarrels of Iron Part 2",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000027","DVD Shura no Toki",59.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000157","MANGA Ultimo 6",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000164","MERCH Gurren Lagann Keychain",6.50,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000171","MERCH Ame-Comi Zatanna",49.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000195","FOOD Pocky Value Pack Chocolate",10.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000201","FOOD Pocky Strawberry Large",4.00,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000140","MANGA Ninja Girls 3",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000133","MANGA Oh My Goddess Volume 20",11.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000126","MANGA Ninja Girls 9",10.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000119","MANGA Gantz 21",12.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000102","MANGA Ouran Host Club 4",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000096","MANGA Ouran Host Club 3",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000089","MANGA Ouran Host Club 2",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000072","MANGA Ouran Host Club 1",8.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000065","MANGA Ouran Host Club 13",9.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000058","MANGA Amazing Agent Luna Omnibus 6-7",14.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("33012000041","MANGA Gunslinger Girl Omnibus 9-10",16.99,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("70462098617","FOOD Sour Patch Kids 5 oz",1.70,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("70462098679","FOOD Sweedish Red Fish",1.70,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("41420744020","FOOD Black Forest Gummy Worms",1.50,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20709012319","FOOD Trolli Sour Brite Octopus",1.70,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20709110435","FOOD Trolli Soda Poppers",1.70,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("41420744112","FOOD Black Forest Gummy Cherries",1.50,0,0);
            Price_Comparison.PriceComparison.set.Rows.Add("20709002402", "FOOD Trolli Classic Bears", 1.70, 0, 0);
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
            Price_Comparison.PriceComparison.firstRecord 
                = Price_Comparison.PriceComparison.currPage * Price_Comparison.PriceComparison.numResultsPerPage;
            Price_Comparison.PriceComparison.lastRecord 
                = Price_Comparison.PriceComparison.firstRecord + Price_Comparison.PriceComparison.numResultsPerPage - 1;
            if (Price_Comparison.PriceComparison.lastRecord >= Price_Comparison.PriceComparison.totalRecords)
            {
                Price_Comparison.PriceComparison.lastRecord = Price_Comparison.PriceComparison.totalRecords - 1;
            }
            Price_Comparison.PriceComparison.totalPages 
                = (int)(Math.Ceiling((Double)(Price_Comparison.PriceComparison.totalRecords / Price_Comparison.PriceComparison.numResultsPerPage)));
            Price_Comparison.PriceComparison.form.lblDisplayedRecords.Text 
                = (Price_Comparison.PriceComparison.firstRecord + 1).ToString() + "-" + (Price_Comparison.PriceComparison.lastRecord + 1).ToString() + " of " + Price_Comparison.PriceComparison.totalRecords.ToString();
        }
    }
}
