namespace _09.FrequentNumber
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

            int mostRepeatedTimes = 1;
            int mostRepeatingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int currentRepeating = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == currentNum)
                    {
                        currentRepeating++;
                    }
                }

                if (currentRepeating > mostRepeatedTimes)
                {
                    mostRepeatedTimes = currentRepeating;
                    mostRepeatingNumber = currentNum;
                }
            }

            Console.WriteLine("{0} ({1} times)", mostRepeatingNumber, mostRepeatedTimes);
        }
    }
}
