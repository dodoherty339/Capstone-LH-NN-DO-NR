using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System.Net;
using System.Collections;

namespace Price_Comparison
{
    class GooglePrices
    {
        public static double getPrice(string barcode)
        {
            string key = "AIzaSyAkuzeoL2MJz--Gk2WSGnotf2qGoCaZdL8";
            //string barcode = "008888526841";
            string sourceCode = getSourceCode("https://www.googleapis.com/shopping/search/v1/public/products?key=" + key + "&country=US&q=" + barcode + "&alt=JSON");
            string subPrice;
            Regex name = new Regex("\"name\": \".*\"");
            Regex condition = new Regex("\"condition\": \".*\"");
            Regex price = new Regex("\"price\": \\d+[.]\\d+");
            Regex shipping = new Regex("\"shipping\": \\d+[.]\\d+,");
            MatchCollection mcn = name.Matches(sourceCode);
            MatchCollection mcc = condition.Matches(sourceCode);
            MatchCollection mcp = price.Matches(sourceCode);
            MatchCollection mcs = shipping.Matches(sourceCode);
            double[] totals = new double[mcp.Count];

            for (int i = 0; i < mcp.Count; ++i)
            {
                subPrice = mcp[i].Value.Substring(9, mcp[i].Value.Length - 9);
                totals[i] = double.Parse(subPrice);
            }

            return AnalyzeResults.StartAnalyze(totals);
        }
    
        public static string getSourceCode(string address)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(address);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string sourceCode = sr.ReadToEnd();
            sr.Close();
            resp.Close();
            return sourceCode;
        }
    }
}
