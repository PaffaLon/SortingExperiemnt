using System;
using System.Collections.Generic;
using System.Text;

namespace SortingExperiemnt
{
    class BubbleSort
    {
        /// <summary>
        /// Sorts an double array from the lowest to largest number.
        /// </summary>
        /// <param name="unsortedList"></param>
        /// <returns>An array sorted by the boubble principle.</returns>
        public double[] Sort(double[] unsortedList)
        {
            double temp;


            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                for (int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            return unsortedList;
        }

        /// <summary>
        /// Prints each item inside an array to the console.
        /// </summary>
        /// <param name="sortedList"></param>
        public void Print(double[] sortedList)
        {
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}// END - BubbleSort.
