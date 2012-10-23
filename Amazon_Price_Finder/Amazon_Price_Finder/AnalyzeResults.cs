using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon_Price_Finder
{
    //! This is the class for analyzing the results obtained from Amazon
    /**
     * It contains methods involved in calculating the average of the prices
     * as well as an adjusted average by identifying outliers with the use of
     * the standard deviation.
     */
    class AnalyzeResults
    {
        //! This is the first method invoked in the AnalyzeResults class
        /**
         * It defines the array of prices and calls the other methods to 
         * calculate the standard deviation and adjusted average.
         */
        public static void StartAnalyze()
        {
            double[] totals = new Double[10];
            double stdDev = 0;
            double sum = 0;
            double average = 0; /*!< average */
            double adjAvg1 = 0;
            double adjAvg2 = 0;
            double adjAvg3 = 0;

            totals[0] = 0.01;
            totals[1] = 100;
            totals[2] = 200;
            totals[3] = 300;
            totals[4] = 400;
            totals[5] = 500;
            totals[6] = 600;
            totals[7] = 700;
            totals[8] = 800;
            totals[9] = 900;

            for (int i = 0; i < totals.Length; i++)
            {
                sum += totals[i];
                Console.WriteLine("Offer" + i + " : $" + totals[i]);
            }

            Console.WriteLine("Sum    : $" + sum);
            if (totals.Length != 0)
            {
                average = sum / totals.Length;
                Console.WriteLine("Avg    : $" + average);
            }
            stdDev = calculateStandardDeviation(totals);
            adjAvg1 = adjustAverage(stdDev, average, totals, 1);
            adjAvg2 = adjustAverage(stdDev, average, totals, 2);
            adjAvg3 = adjustAverage(stdDev, average, totals, 3);

            Console.WriteLine("StdDev : $" + stdDev);
            Console.WriteLine("AdjAvg1: $" + adjAvg1);
            Console.WriteLine("AdjAvg2: $" + adjAvg2);
            Console.WriteLine("AdjAvg3: $" + adjAvg3);
            //Console.WriteLine("Press enter to close window.");
            //Console.ReadKey();
        }

        //! This method calculates the standard deviation of the array
        /**
         * It contains methods involved in calculating the average of the prices
         * as well as an adjusted average by identifying outliers with the use of
         * the standard deviation.
         */
        public static double calculateStandardDeviation(
          double[] totals /*!< a list of prices */
        )
        {
            double stdDev = 0;
            if (totals.Length > 1)
            {
                double sum = 0;
                for (int i = 0; i < totals.Length; i++)
                {
                    sum += totals[i];
                }

                double average = sum / totals.Length;

                double sumDiffs = 0;
                for (int j = 0; j < totals.Length; j++)
                {
                    sumDiffs += Math.Pow(totals[j] - average, 2);
                }

                double variance = sumDiffs / (totals.Length - 1);
                stdDev = Math.Sqrt(variance);
            }
            
            return stdDev;
        }

        //! This method calculates an adjusted average for the prices
        /**
         * It takes the standard deviation calculated in the previous method
         * and an integer representing the number of standard deviations to use
         * and determines a range of acceptable values.  Any values outside of
         * that range are considered "outliers" and are ignored in the 
         * calculation of a new average.
         * 
         * <b>Note:</b> The "numDev" parameter is included to allow for a
         * smaller range of numbers to be determined acceptable.  Standard
         * practice says that outliers must be at least 3 standard deviations
         * from the mean.
         */
        public static double adjustAverage(
          double stdDev     /*!< the standard deviation of the values */
        , double avg        /*!< the raw average of the values */
        , double[] totals   /*!< a list of prices */
        , int numDev        /*!< the number of standard deviations to use */
        )
        {
            double adjAvg = 0;
            double highOut = avg + numDev * stdDev;
            double lowOut = avg - numDev * stdDev;
            double sum = 0;
            double count = 0;
            if (totals.Length != 0)
            {
                for (int i = 0; i < totals.Length; i++)
                {
                    if ( totals[i] >= lowOut && totals[i] <= highOut)
                    {
                        count++;
                        sum += totals[i];
                    }
                }
            }

            if (count != 0)
            {
                adjAvg = sum / count;
            }

            return adjAvg;
        }
    }
}