using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace Price_Comparison
{
    //! The class for displaying the results table.
    /**
     * This class contains methods that display the records on the form.
     */
    class DisplayResultsTable
    {
        //! This is the method that updates the database (using the hardcoded set of records).
        /**
         * This method is passed the index of the record on the form that has 
         * been updated.  First it strips out all characters except digits and 
         * the decimal point.  Next it finds the record in the set and modifies
         * its database price and the difference between the online price and 
         * the database price.  Finally, it displays the table.
         */
        public static void UpdateDatabase(
          int index /*!< the index into the results table on the form for the record to be updated */
        )
        {
            PriceComparison.form.tblResults["DatabasePrice", index].Value 
                = Regex.Replace(PriceComparison.form.tblResults["DatabasePrice", index].Value.ToString(), @"[^\d\.-]", "");
            DataRow row = PriceComparison.set.Select("Barcode = '" + PriceComparison.form.tblResults["Barcode", index].Value.ToString() + "'")[0];
            double newPrice;
            if ( double.TryParse(PriceComparison.form.tblResults["DatabasePrice", index].Value.ToString(), out newPrice))
            {
                if ( newPrice > 0)
                {
                    row["dbPrice"] = PriceComparison.form.tblResults["DatabasePrice", index].Value;
                    row["diff"] = (Double)row["onlinePrice"] - (Double)row["dbPrice"];
                }
            }
            displayTable();
        }

        //! This is the method that displays the table on the form.
        /**
         * This method sorts the rows based on the current sort and filter 
         * parameters.  Then it sets the total records to display to the length
         * of the sorted array.  Then it calculates the first and last record 
         * on the current page.  It clears the previous results table, then 
         * iterates through the table starting with the first record through
         * the last record, adding a new row and displaying it for each record.
         * 
         * If there are no rows in the array, generally indicating that there
         * are no results in the current filter, a message is displayed 
         * indicating the set is empty.
         */
        public static void displayTable()
        {
            PriceComparison.sortedRows = sortFilterRows();
            PriceComparison.totalRecordsToDisplay = PriceComparison.sortedRows.Length;
            setFirstLastRecord();
            int count = 0;
            PriceComparison.form.tblResults.Rows.Clear();
            if (PriceComparison.sortedRows.Length > 0)
            {
                for (int i = PriceComparison.firstRecord; i <= PriceComparison.lastRecord && i < PriceComparison.totalRecordsToDisplay; i++)
                {
                    PriceComparison.form.tblResults.Rows.Add();
                    displayRow(count, PriceComparison.sortedRows[i]);
                    count++;
                }
            }
            else
            {
                PriceComparison.form.tblResults.Rows.Add();
                PriceComparison.form.tblResults["Description", 0].Value = "The current filter contains no records.";
                PriceComparison.form.lblDisplayedRecords.Text = "0-0 of 0";
            }
        }

        //! This is the method that displays a row on the form.
        /**
         * This method takes two parameters: the row number into the table on
         * the form and the row data itself.  First the barcode and description
         * are copied directly from the row data to the table.  The database
         * price and online price are formatted as "$x.xx".  The online price, 
         * however, is tested for whether it is equal to 0, and if it is "N/A"
         * is displayed instead of "$0.00" and the difference is displayed as 
         * "-" and set to 0.  If the difference is negative, it is displayed 
         * as "-x.xx", and the cell is colored red.  If the difference is 
         * positive, it is displayed as "+x.xx", and the cell is colored green.
         */
        public static void displayRow(
          int rowNum /*!< the row number of the record to be displayed */
        , DataRow row /*!< the data for the row to be displayed */
        )
        {
            PriceComparison.form.tblResults["Barcode", rowNum].Value = row["Barcode"].ToString();
            PriceComparison.form.tblResults["Description", rowNum].Value = row["Dscr"].ToString();
            PriceComparison.form.tblResults["DatabasePrice", rowNum].Value = String.Format("{0:$0.00}", (Double)row["dbPrice"]);

            if ((Double)row["onlinePrice"] == 0)
            {
                PriceComparison.form.tblResults["OnlinePrice", rowNum].Value = "N/A";
                PriceComparison.form.tblResults["Difference", rowNum].Value = "-";
                row["diff"] = 0;
            }
            else
            {
                PriceComparison.form.tblResults["OnlinePrice", rowNum].Value = String.Format("{0:$0.00}", (Double)row["onlinePrice"]);
                if ((Double)row["diff"] < 0)
                {
                    PriceComparison.form.tblResults["Difference", rowNum].Style.BackColor = System.Drawing.Color.Tomato;
                    PriceComparison.form.tblResults["Difference", rowNum].Value = String.Format("{0:0.00}", (Double)row["diff"]);
                }
                if ((Double)row["diff"] > 0)
                {
                    PriceComparison.form.tblResults["Difference", rowNum].Style.BackColor = System.Drawing.Color.LimeGreen;
;
                    PriceComparison.form.tblResults["Difference", rowNum].Value = String.Format("+{0:0.00}", (Double)row["diff"]);
                }
                if ((Double)row["diff"] == 0)
                {
                    PriceComparison.form.tblResults["Difference", rowNum].Style.BackColor = System.Drawing.Color.White;
                    PriceComparison.form.tblResults["Difference", rowNum].Value = "0.00";
                }
            }            
        }

        //! This is the method that sorts and filters the set.
        /**
         * This method selects and returns all rows that fit into the currently
         * assigned filter sorted by the currently assigned sort parameters.
         */
        public static DataRow[] sortFilterRows()
        {
            return PriceComparison.set.Select(PriceComparison.filter, PriceComparison.sortCol);
        }

        //! This is the method that sets the first and last record.
        /**
         * This method sets the number of the first and last records on the 
         * current page.  The first record is the current page times the 
         * number of results per page; the last record is the first record plus
         * the number of results per page minus 1.  If the number of the last 
         * record is higher than the total number of records, the last record
         * is set to the total number of records minus 1 (this is done because
         * the values act as indices into the sorted array).  
         * 
         * Next the total number of pages is set to the ceiling of total 
         * records divided by the number of results per page.  
         * 
         * Finally, text is displayed on screen indicating the records 
         * currently displayed.  It displays the first record plus 1 and the 
         * last record plus 1 because they are actually stored starting at 0 
         * instead of 1.
         */
        public static void setFirstLastRecord()
        {
            PriceComparison.firstRecord 
                = PriceComparison.currPage * PriceComparison.numResultsPerPage;
            PriceComparison.lastRecord 
                = PriceComparison.firstRecord + PriceComparison.numResultsPerPage - 1;
            if (PriceComparison.lastRecord >= PriceComparison.totalRecordsToDisplay)
            {
                PriceComparison.lastRecord = PriceComparison.totalRecordsToDisplay - 1;
            }
            PriceComparison.totalPages 
                = (int)(Math.Ceiling((Double)(PriceComparison.totalRecordsToDisplay / PriceComparison.numResultsPerPage)));
            PriceComparison.form.lblDisplayedRecords.Text 
                = (PriceComparison.firstRecord + 1).ToString() + "-" + (PriceComparison.lastRecord + 1).ToString() + " of " + PriceComparison.totalRecordsToDisplay.ToString();
        }

        //! This is the method that creates the hardcoded set.
        /**
         * This method contains the hardcoded data for the set.
         */
        public static void createSet()
        {
            PriceComparison.set.Rows.Add("013023127937", "3X3 Eyes (VHS)", 7.99,0, 0);
            PriceComparison.set.Rows.Add("013023156890", "Akira", 12.99,0, 0);
            PriceComparison.set.Rows.Add("013023173132", "Ah! My Goddess The Movie (VHS)", 3.99,0, 0);
            PriceComparison.set.Rows.Add("013023234796", "Tsukihime 1", 6.99,0, 0);
            PriceComparison.set.Rows.Add("013023234895", "Tsukihime 2", 9.99,0, 0);
            PriceComparison.set.Rows.Add("013023285996", "Melody of Oblivion Collection", 50.99,0, 0);
            PriceComparison.set.Rows.Add("013138200891", "Guyver Collection", 33.99,0, 0);
            PriceComparison.set.Rows.Add("013138500298", "Tokko 1", 6.99,0, 0);
            PriceComparison.set.Rows.Add("013138500397", "Tokko 2", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("013138500496", "Tokko 3", 7.99, 0, 0);
            PriceComparison.set.Rows.Add("014764190228", "Samurai Jack the Movie", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("024543718307", "Vampires Suck", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("025192024078", "Pokemon Giratina", 9.99, 0, 0);
            PriceComparison.set.Rows.Add("027616852854", "Heavy Traffic", 7.99, 0, 0);
            PriceComparison.set.Rows.Add("043396077966", "Metropolis", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("043396190702", "Tekkonkinkreet", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("044004607735", "Angel Cop The Collection (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("044005559538", "Sword For Truth", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("047875122000", "Alundra 2", 9.99, 0, 0);
            PriceComparison.set.Rows.Add("053939670820", "Aqua Teen Hunger Force Vol. 1", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("053939781625", "Venture Bros Season 2", 17.99, 0, 0);
            PriceComparison.set.Rows.Add("631595021875", "Gundress The Movie", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("631595082579", "Moribito 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("631595086973", "Moribito 2", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("631595087475", "Morbito 3", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("631595087574", "Moribito Volume 4", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("631595095975", "Used Moribito 6", 7.99, 0, 0);
            PriceComparison.set.Rows.Add("631595098075", "Moribito 8", 9.99, 0, 0);
            PriceComparison.set.Rows.Add("638652102430", "Tekkaman Blade II: Stage 1 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("638652102836", "Tekkaman Blade II: Stage 2 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("638652103031", "Tekkaman Blade II Stage 3 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("638652104632", "Golgo 13 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("638652109309", "Vampire Hunter D Bloodlust", 13.99, 0, 0);
            PriceComparison.set.Rows.Add("645573009991", "DN Angel 8", 5, 0, 0);
            PriceComparison.set.Rows.Add("645573019990", "Shirahime Syo", 10, 0, 0);
            PriceComparison.set.Rows.Add("645573044794", "Kare Kano 1", 5, 0, 0);
            PriceComparison.set.Rows.Add("660200401733", "Black Jack (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("660200404437", "X (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("660200404734", "Perfect Blue (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("660200407834", "Blood The Last Vampire (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("660200413828", "Kai Doh Maru", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("669198208621", "Flag 3", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("669198208638", "Flag 4", 7.99, 0, 0);
            PriceComparison.set.Rows.Add("669198225093", "Argentosoma 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("669198252686", "Ghost in the Shell Stand Alone Complex", 34.99, 0, 0);
            PriceComparison.set.Rows.Add("669198262500", "Avenger Complete Collection", 15.99, 0, 0);
            PriceComparison.set.Rows.Add("669198802614", "S-CRY-ed", 49.99, 0, 0);
            PriceComparison.set.Rows.Add("669198804021", "Gurren Lagann 3", 45.99, 0, 0);
            PriceComparison.set.Rows.Add("678149175721", "Ghost in the Shell 2", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("702727006524", "USED Golden Boy Vol. 1", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("702727011238", "Slayers The Motion Picture (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727012228", "Steel Angel Kurumi 1", 11.99, 0, 0);
            PriceComparison.set.Rows.Add("702727021527", "USED Spriggan", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("702727023521", "Excel Saga Vol. 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("702727027826", "Zone of the Enders Idolo", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("702727038624", "USED Voices of a Distant Star", 26.99, 0, 0);
            PriceComparison.set.Rows.Add("702727044533", "Dragoon (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727045134", "Queen Emeraldas (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727063732", "Samurai X Trust (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727063831", "Samurai X Betreyal  (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727063930", "Samurai X The Motion Picture (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727070433", "Son (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("702727075629", "Robotech Vol 2", 9.99, 0, 0);
            PriceComparison.set.Rows.Add("702727078729", "Evangelion Platnium 2", 8.99, 0, 0);
            PriceComparison.set.Rows.Add("702727081323", "Evangelion Directors Cut Resurrection", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("702727081422", "Evangelion Directors Cut Genesis", 8.99, 0, 0);
            PriceComparison.set.Rows.Add("702727083921", "Legend of Crystania", 12.99, 0, 0);
            PriceComparison.set.Rows.Add("702727110924", "Elfen Lied 1", 10.99, 0, 0);
            PriceComparison.set.Rows.Add("702727127021", "Noir", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("702727132124", "Peacemaker", 30, 0, 0);
            PriceComparison.set.Rows.Add("702727132322", "Neon Genesis Evangelion", 67.99, 0, 0);
            PriceComparison.set.Rows.Add("702727141522", "Gantz Collection 1", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("702727143724", "Mezzo TV Collection", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("702727143823", "Neo Ranga", 26.99, 0, 0);
            PriceComparison.set.Rows.Add("702727144721", "Zone of the Enders Collection", 44.99, 0, 0);
            PriceComparison.set.Rows.Add("702727146824", "Gantz Collection 2", 18.99, 0, 0);
            PriceComparison.set.Rows.Add("702727155529", "Saiyuki", 45.99, 0, 0);
            PriceComparison.set.Rows.Add("702727176029", "Blue Seed Mitama Collection", 20.99, 0, 0);
            PriceComparison.set.Rows.Add("702727186325", "Sorcerer Hunters", 46.99, 0, 0);
            PriceComparison.set.Rows.Add("704400011702", "USED- Soul Eater Part One", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("704400011764", "Soul Eater Collection 1", 42.99, 0, 0);
            PriceComparison.set.Rows.Add("704400011801", "Spice and Wolf Season 1", 41.99, 0, 0);
            PriceComparison.set.Rows.Add("704400023729", "Origin Spirits of the Past", 12.99, 0, 0);
            PriceComparison.set.Rows.Add("704400052507", "Blue Gender", 26.99, 0, 0);
            PriceComparison.set.Rows.Add("704400052538", "Blue Gender Vol. 1 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("704400069154", "Desert Punk", 21.99, 0, 0);
            PriceComparison.set.Rows.Add("704400074479", "Claymore", 39.99, 0, 0);
            PriceComparison.set.Rows.Add("704400075223", "Kiddy Grade Vol. 3", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400075643", "Kiddy Grade Vol. 8", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400079078", "Glass Fleet", 32.99, 0, 0);
            PriceComparison.set.Rows.Add("704400079160", "Hetalia Complete Series", 38.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081323", "Fullmetal Alchemist 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081347", "Fullmetal Alchemist 2", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081361", "Fullmetal Alchemist 3", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081385", "Fullmetal Alchemist 4", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081422", "Fullmetal Alchemist 5", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081460", "Fullmetal Alchemist 7", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081484", "Fullmetal Alchemist 8", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081521", "Fullmetal Alchemist 9", 8.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081545", "Fullmetal Alchemist 10", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081569", "Fullmetal Alchemist 11", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("704400081583", "Fullmetal Alchemist 12", 7.99, 0, 0);
            PriceComparison.set.Rows.Add("704400082108", "Ergo Proxy", 33.99, 0, 0);
            PriceComparison.set.Rows.Add("704400084379", "Hellsing Ultimate 4", 19.99, 0, 0);
            PriceComparison.set.Rows.Add("704400084522", "Trinity Blood Volume 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400084553", "Trinity Blood Volume 2 Limited", 10.99, 0, 0);
            PriceComparison.set.Rows.Add("704400084577", "Trinity Blood 3 Limited", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("704400084690", "Trinity Blood", 25.99, 0, 0);
            PriceComparison.set.Rows.Add("704400096259", "Baccano", 35.99, 0, 0);
            PriceComparison.set.Rows.Add("704400096655", "Welcome to the NHK", 57.99, 0, 0);
            PriceComparison.set.Rows.Add("719987106833", "Project A-Ko", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987113633", "Project A-Ko Versus Battle 1 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987166530", "Wrath of the Ninja The Yotoden Movie (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987202436", "Harlock Saga Clash of the Space Pirates", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987202535", "Harlock Saga Wrath of the Gods (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987204232", "Angel Sanctuary (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("719987207325", "Project AKo Complete Collection", 89.99, 0, 0);
            PriceComparison.set.Rows.Add("735366005535", "Alundra", 29.99, 0, 0);
            PriceComparison.set.Rows.Add("735366010713", "Lunar 2 Eternal Blue", 59.99, 0, 0);
            PriceComparison.set.Rows.Add("742617801129", "His and Her Circumstances 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("780063479134", "DevilMan Vol. 1", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("780063479332", "DevilMan Vol. 2 (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("780063552929", "Ghost in the Shell", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("780063553537", "The Guyver: Data 1  (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("782009234258", "InuYahsa Movie 3", 6.99, 0, 0);
            PriceComparison.set.Rows.Add("782009235378", "Naruto Uncut Season 1 Part 1", 18.99, 0, 0);
            PriceComparison.set.Rows.Add("782009235385", "Naruto Uncut Box 2", 10.99, 0, 0);
            PriceComparison.set.Rows.Add("782009239215", "Deathnote Vol. 1", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("782009240105", "Deathnote Vol. 2", 22.99, 0, 0);
            PriceComparison.set.Rows.Add("786936175240", "Nausicaa of the Valley of the Wind", 20.99, 0, 0);
            PriceComparison.set.Rows.Add("786936229417", "Pokemon Heroes the Movie", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("795243612232", "Slayers Try: Pandemonium (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("795243612430", "Slayers Try: A Hero Descends (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("795243612638", "The Slayers Try: Showdown (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("795243612836", "The Slayers Try: Try Again (VHS)", 3.99, 0, 0);
            PriceComparison.set.Rows.Add("814131011909", "Tears to Tiara Collection 1", 18.99, 0, 0);
            PriceComparison.set.Rows.Add("814131013217", "Shigofumi Complete Collection", 41.99, 0, 0);
            PriceComparison.set.Rows.Add("814131016720", "Majikoi Oh Samurai Girls", 59.99, 0, 0);
            PriceComparison.set.Rows.Add("828311121005", "Risky Safety 1", 5.99, 0, 0);
            PriceComparison.set.Rows.Add("883929053155", "Venture Bros 3rd Season", 16.99, 0, 0);
        }
    }
}
