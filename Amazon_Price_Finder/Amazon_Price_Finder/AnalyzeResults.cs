using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Price_Comparison
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
        public static double StartAnalyze(double[] totals)
        {
            // Possibly analyze difference between median and mean.
            double stdDev = 0;
            double sum = 0;
            double mean = 0;
            double adjMean = 0;
            
            Array.Sort(totals);
            for (int i = 0; i < totals.Length; i++)
            {
                sum += totals[i];
                //Console.WriteLine("Offer" + i + " : $" + totals[i]);
            }

            //Console.WriteLine("Sum     : $" + sum);
            if (totals.Length != 0)
            {
                mean = sum / totals.Length;
                //Console.WriteLine("Mean    : $" + mean);
            }
            stdDev = calculateStandardDeviation(totals);
            adjMean = adjustMean(stdDev, mean, totals);

            //Console.WriteLine("StdDev  : $" + stdDev);
            //Console.WriteLine("AdjMean : $" + adjMean);
            //Console.WriteLine("Press enter to close window.");
            //Console.ReadKey();

            return adjMean;
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
        public static double adjustMean(
          double stdDev     /*!< the standard deviation of the values */
        , double mean        /*!< the raw average of the values */
        , double[] totals   /*!< a list of prices */
        )
        {
            double adjAvg = 0;
            double highOut = mean + 2 * stdDev;
            double lowOut = mean - 2 * stdDev;
            double sum = 0;
            double count = 0;
            if (totals.Length != 0)
            {
                for (int i = 0; i < totals.Length; i++)
                {
                    if (totals[i] >= lowOut && totals[i] <= highOut)
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