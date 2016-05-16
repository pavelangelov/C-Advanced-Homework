namespace _14.IntegerCalculations
{
    using System;

    class Program
    {
        private static string[] numbers = Console.ReadLine().Split(' ');
        private static int min = 1000;
        private static int max = -1000;
        private static double average;
        private static int sum = 0;
        private static long product = 1;

        static void Main()
        {
            FindMinMaxAverageSumAndProduct(numbers);

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        

        private static void FindMinMaxAverageSumAndProduct(string[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = int.Parse(numbers[i]);
                if (min > currentNum)
                {
                    min = currentNum;
                }
                if (max < currentNum)
                {
                    max = currentNum;
                }
                sum += currentNum;
                product *= currentNum;
            }

            average = (double)sum / numbers.Length;
        }
    }
}
