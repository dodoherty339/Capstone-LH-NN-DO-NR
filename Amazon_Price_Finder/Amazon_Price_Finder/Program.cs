using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;
using WindowsFormsApplication1;
using Amazon_Price_Finder;

class Program
{

    static void Main(String[] args)
    {
        WindowsFormsApplication1.formAmazonPrice form = new WindowsFormsApplication1.formAmazonPrice();
        
        AmazonRequest.SendRequest();
        AnalyzeResults.StartAnalyze();
        
        form.ShowDialog();
    }
}