using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Diagnostics;
using Amazon_Price_Finder.amazon.ecs;

namespace Amazon_Price_Finder
{
    //! This is the class representing the request sent to Amazon
    /**
     * It contains code obtained from the "Product Advertising API Getting 
     * Started Guide API Version 2011-08-01" found at 
     * http://aws.amazon.com/archives/Product-Advertising-API/.
     */
    public class AmazonRequest
    {
        private const string accessKeyId = "AKIAIZFYONMON7O5DRNA";
        private const string secret = "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";
        private const string assocTag = "";

        //! This is the method that defines a search and sends a request to Amazon
        /**
         * It contains code obtained from the "Product Advertising API Getting 
         * Started Guide API Version 2011-08-01" found at 
         * http://aws.amazon.com/archives/Product-Advertising-API/.
         */
        public static void SendRequest()
        {
            // Get searchIndex and keywords from the command line
            string searchIndex = "DVD";
            string keywords = "Matrix";
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

                //ItemLookup itemLookup = new ItemLookup();
                //ItemLookupRequest itemLookupRequest = new ItemLookupRequest();
                //itemLookupRequest.SearchIndex = "DVD";
                //itemLookupRequest.ItemId = new string[] { "B005OCFGTO" };
                //itemLookupRequest.ResponseGroup = new string[] { "ItemAttributes" };
                //itemLookup.Request = new ItemLookupRequest[] { itemLookupRequest };
                //itemLookup.AWSAccessKeyId = accessKeyId;
                //ItemLookupResponse response = ecs.ItemLookup(itemLookup);

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
                /*
                 * ==Error==    	            ==Description==
                 * IncompleteSignature 	        The request signature does not conform to AWS standards. 
                 * 
                 * InvalidAction 	            The action or operation requested is invalid. 
                 * 
                 * InvalidParameterCombination  Parameters that must not be used together were used together. 
                 *                              
                 * InvalidParameterValue 	    A bad or out-of-range value was supplied for the input parameter.
                 *                              
                 * InvalidQueryParameter 	    AWS query string is malformed, does not adhere to AWS standards.
                 *                              
                 * MissingAction 	            The request is missing an action or operation parameter.
                 * 
                 * MissingParameter 	        An input parameter that is mandatory for processing the 
                 *                              request is not supplied.
                 *                              
                 * RequestExpired 	            Request is past expires date or the request date 
                 *                              (either with 15 minute padding), or the request date 
                 *                              occurs more than 15 minutes in the future.
                 *                              
                 * Throttling 	                Request was denied due to request throttling.
                 */
            }
            Console.WriteLine("Press any key to quit...");
            //Console.ReadKey();
        }
    }
}
