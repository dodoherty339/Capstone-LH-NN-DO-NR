using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;
using Amazon_Price_Finder.amazon.ecs;

class Program
{
    private const string accessKeyId = "AKIAIZFYONMON7O5DRNA";
    private const string secret = "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";
    private const string assocTag = "Lucyh";

    static void Main(String[] args)
    {
        // Write to console
        Console.WriteLine("Welcome to the C# Station Tutorial!");

        // Set default args if two are not supplied
        if (args.Length != 2)
        {
            args = new string[] { "DVD", "Matrix" };
        }
        // Get searchIndex and keywords from the command line
        string searchIndex = args[0];
        string keywords = args[1];
        // Create an instance of the Product Advertising API service
        AWSECommerceServicePortTypeClient ecs = new AWSECommerceServicePortTypeClient();
        /* Error:
         * An endpoint configuration section for contract 'amazon.ecs.AWSECommerceServicePortType' 
         * could not be loaded because more than one endpoint configuration for that contract was 
         * found. Please indicate the preferred endpoint configuration section by name.
         */

        // Create ItemSearch wrapper
        ItemSearch search = new ItemSearch();
        //search.AssociateTag = assocTag;
        search.AWSAccessKeyId = accessKeyId;
        // Create a request object
        ItemSearchRequest request = new ItemSearchRequest();
        // Fill request object with request parameters
        request.ResponseGroup = new string[] { "ItemAttributes" };
        // Set SearchIndex and Keywords
        request.SearchIndex = searchIndex;
        request.Keywords = keywords;
        // Set the request on the search wrapper
        search.Request = new ItemSearchRequest[] { request };
        Console.WriteLine(request.Keywords);
        try
        {
            //Send the request and store the response in response
            Console.WriteLine("try...");
            ItemSearchResponse response = ecs.ItemSearch(search);
            //Check for null response
            if (response == null)
            {
                throw new Exception("Server Error - no response recieved!");
            }
            //ItemSearchResult[] itemsArray = response.GetItemSearchResult;
            if (response.OperationRequest.Errors != null)
            {
                throw new Exception(response.OperationRequest.Errors[0].Message);
            }
            Console.WriteLine("Response: " + response.ToString());
            Console.WriteLine("Length: " + response.Items.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine("...catch");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Err: " + e.Message);
            Console.WriteLine("Type: " + e.GetType());
            Console.WriteLine("Inner Exception: " + e.InnerException.Message);
            Console.ForegroundColor = ConsoleColor.White;
            // http://www.webdesigncompany.co.uk/blog/2011/10/5/using-the-new-amazon-product-api-wsdl-with-microsoftwebservices3/
            // Err: The remote server returned an unexpected response: (400) Bad Request.
        }
        //Console.WriteLine("Press any key to quit...");
        //Console.ReadKey();
    }
}