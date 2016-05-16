namespace _09.SortingArray
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static int lenght = int.Parse(Console.ReadLine());
        private static List<int> numbers = new List<int>();

        static void Main()
        {
            InitSortedArr();

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InitSortedArr()
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < lenght; i++)
            {
                int currentNum = int.Parse(input[i]);
                int index = CheckForBiggerNumber(currentNum, numbers);
                if (index < 0)
                {
                    numbers.Add(currentNum);
                }
                else
                {
                    numbers.Insert(index, currentNum);
                }
            }
        }

        private static int CheckForBiggerNumber(int number, List<int> numbers)
        {
            int index = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (number < numbers[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
