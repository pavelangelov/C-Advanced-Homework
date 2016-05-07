namespace _06.Maximal_K_sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maximalSum = 0;
            int index = -1;
            for (int i = 0; i < k; i++)
            {
                int currentBiggest = int.MinValue;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (currentBiggest <= numbers[j] && j != index)
                    {
                        currentBiggest = numbers[j];
                        index = j;
                    }
                }

                if (index >= 0)
                {
                    numbers[index] = int.MinValue;
                    maximalSum += currentBiggest;
                }
                index = -1;

            }

            Console.WriteLine(maximalSum);
        }
    }
}
