using System;

namespace SortingExperiemnt
{
    class Program
    {
        static void Main()
        {
            // First I'm instansiating the varaibles I need in this method.
            double[] numbers = { 10, 5, 30, 15, 20 };
            double[] sortedList = new double[5];

            string[] fruits = new string[5];
            fruits[0] = "Päron";
            fruits[1] = "Äpple";
            fruits[2] = "Banan";
            fruits[3] = "Annans";
            fruits[4] = "Gurka";
                
            // Then I create the instances of the classes, I'm going to call from here.
            BubbleSort bubbleSort = new BubbleSort();
            CharacterSort characterSort = new CharacterSort();
            BinarySearch binarySearch = new BinarySearch();


            sortedList = bubbleSort.Sort(numbers);
            //
            //......

            Spacing(1);
            Console.WriteLine($"Sorted the array of numbers in a rising order. {Environment.NewLine}");
            bubbleSort.Print(sortedList);
            //
            //
            //......
            
            Spacing(1);
            Console.WriteLine($"Sorted the array of strings alphabetical order. {Environment.NewLine}");
            characterSort.Print(characterSort.AscendingOrder(fruits));
            //
            //
            //......
            Spacing(1);
            Console.WriteLine($"Sorted the array of strings non-alphabetical order. {Environment.NewLine}");
            characterSort.Print(characterSort.DescendingOrder(fruits));
            //
            //
            //......

            Spacing(2);
            binarySearch.Setup();
        }

        private static void Spacing(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
