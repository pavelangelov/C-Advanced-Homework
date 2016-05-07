namespace _04.MaximalSequence
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

            int maximalSequence = 1;
            int currentSequence = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum == numbers[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maximalSequence)
                {
                    maximalSequence = currentSequence;
                }
            }

            Console.WriteLine(maximalSequence);
        }
    }
}
