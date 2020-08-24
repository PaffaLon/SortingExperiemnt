using System;
using System.Collections.Generic;
using System.Text;

namespace SortingExperiemnt
{
    // Reference link fir Binary Serch.
    // https://www.youtube.com/watch?v=fOMh45TT0BI
    class BinarySearch
    {
        public void Setup()
        {
            int[] numbers = { 10, 5, 30, 15, 20 };
            Array.Sort(numbers);

            var index = LinearSerch(numbers, 3);
            Console.WriteLine(index);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">An array of integers.</param>
        /// <param name="item">An array element position.</param>
        /// <returns></returns>
        private int LinearSerch(int[] array, int item)
        {
            for (int element = 0; element < array.Length; element++)
            {
                if (array[element] == item)
                {
                    return element;
                }
            }

            return -1;
        }

        private int SearchBinary(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;

            while(left <= right)
            {
                var middle = (left + right) / 2;
                //
                //......
                if (array[middle] == item)
                    return middle;

                if (item < array[middle])
                    right = middle - 1;



                else
                    left = middle + 1;
            }

            return -1;
        }
    }
}// END - Binary Search.
