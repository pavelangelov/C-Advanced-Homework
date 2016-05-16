namespace _06.FirstLargerThanNeighbours
{
    using System;

    class Program
    {
        private static int index = -1;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            numbers = InitArr(numbers);

            CheckForNumberBiggerThanNeighbours(numbers);

            Console.WriteLine(index);
        }

        private static void CheckForNumberBiggerThanNeighbours(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                int currentNum = numbers[i];
                if (numbers[i - 1] < currentNum && currentNum > numbers[i + 1])
                {
                    index = i;
                    return;
                }
            }
        }

        private static int[] InitArr(int[] numbers)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            return numbers;
        }
    }
}
