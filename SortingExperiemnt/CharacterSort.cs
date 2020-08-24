using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace SortingExperiemnt
{
    class CharacterSort
    {
        /// <summary>
        /// Sorts an array of strings in an ascending order.
        /// </summary>
        /// <param name="unorderdList"></param>
        /// <returns></returns>
        public string[] AscendingOrder(string[] unorderdList)
        {
            var result = unorderdList.OrderBy(i => i);
            

            return result.ToArray();
        }


        /// <summary>
        /// Sorts an array of string in a descending order.
        /// </summary>
        /// <param name="unorderdList"></param>
        /// <returns></returns>
        public string[] DescendingOrder(string[] unorderdList)
        {
            var result = unorderdList.OrderByDescending(i => i);


            return result.ToArray();
        }



        /// <summary>
        /// Prints an array of strings.
        /// </summary>
        public void Print(string[] resivedPacket)
        {
            foreach (var item in resivedPacket)
            {
                Console.WriteLine(item);
            }
        }
    }
}// END - CharacterSort
