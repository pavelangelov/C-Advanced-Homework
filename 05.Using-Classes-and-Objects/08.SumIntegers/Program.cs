namespace _08.SumIntegers
{
    using System;

    class Program
    {
        static void Main()
        {
            string numbersStr = Console.ReadLine();

            long result = SumOfNumbersFromStr(numbersStr);

            Console.WriteLine(result);
        }

        private static long SumOfNumbersFromStr(string numbersStr)
        {
            long sum = 0;
            string[] numbers = numbersStr.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            return sum;
        }
    }
}
