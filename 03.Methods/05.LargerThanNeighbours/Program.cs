namespace _05.LargerThanNeighbours
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            InitArray(numbers);

            int numbersLargestThanNeighbours = CountNumbersLargestTahnNeighbours(numbers);

            Console.WriteLine(numbersLargestThanNeighbours);
        }

        private static int CountNumbersLargestTahnNeighbours(int[] numbers)
        {
            int result = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                int currentNum = numbers[i];
                bool isBigger = false;

                if (currentNum > numbers[i - 1] && currentNum > numbers[i + 1])
                {
                    isBigger = true;
                }

                if (isBigger)
                {
                    result++;
                }
            }

            return result;
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
