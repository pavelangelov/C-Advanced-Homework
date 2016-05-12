namespace _04.AppearanceCount
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            InitArray(numbers);

            int searchedNumber = int.Parse(Console.ReadLine());
            int appears = CountAppears(numbers, searchedNumber);

            Console.WriteLine(appears);
        }

        private static int CountAppears(int[] numbers, int searchedNumber)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == searchedNumber)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static void InitArray(int[] numbers)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }
        }
    }
}
