namespace _08.MaximalSum
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            int biggestSum = sum;
            int startIndex = 0;
            int currentSum = sum;
            int len = numbers.Length;
            int lastNum = numbers.Length - 1;

            while (lastNum > 0)
            {
                if (biggestSum < currentSum)
                {
                    biggestSum = currentSum;
                }

                currentSum -= numbers[startIndex];

                if (startIndex == lastNum - 1)
                {
                    sum -= numbers[lastNum];
                    startIndex = 0;
                    lastNum--;
                    currentSum = sum;
                    continue;
                }

                startIndex++;
            }

            Console.WriteLine(biggestSum);
        }
    }
}
