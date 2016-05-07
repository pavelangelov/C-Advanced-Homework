namespace _05.MaximalincreasingSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maximalIncreasingSequence = 0;
            int currentIncreasingSequence = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (currentNum < numbers[j + 1])
                    {
                        currentIncreasingSequence++;
                    }
                    else if (currentNum == numbers[j + 1])
                    {
                        break;
                    }
                    
                }

                if (currentIncreasingSequence > maximalIncreasingSequence)
                {
                    maximalIncreasingSequence = currentIncreasingSequence;
                }
                currentIncreasingSequence = 1;
            }

            Console.WriteLine(maximalIncreasingSequence);
        }
    }
}
