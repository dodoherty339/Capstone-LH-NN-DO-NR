using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon_Price_Finder
{
    class AnalyzeResults
    {
        public static void StartAnalyze()
        {
            double[] totals = new Double[10];
            double stdDev = 0;
            double sum = 0;
            double average = 0;
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

        public static double calculateStandardDeviation(double[] totals)
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

        public static double adjustAverage(double stdDev, double avg, double[] totals, int numDev)
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