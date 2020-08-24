using System;
using System.Collections.Generic;
using System.Text;

namespace SortingExperiemnt
{
    class BinarySearch
    {
        public void Setup()
        {
            int[] numbers = { 10, 5, 30, 15, 20 };
            Array.Sort(numbers);

            var index = LinearSerch(numbers, 1);
            Console.WriteLine(index);
        }

        private static int LinearSerch(int[] array, int item)
        {
            for (int i = 0; i > array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int SearchBinary(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;

            while(left <= right)
            {
                var middle = (left + right) / 2;


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
