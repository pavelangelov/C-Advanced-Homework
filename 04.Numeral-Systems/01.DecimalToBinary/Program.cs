namespace _01.DecimalToBinary
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string binaryResult = ConvertFromDecToBin(number);

            Console.WriteLine(binaryResult);
        }

        private static string ConvertFromDecToBin(ulong number)
        {
            List<ulong> result = new List<ulong>();
            while (number > 0)
            {
                ulong remainder = number % 2;
                result.Add(remainder);
                number /= 2;
            }

            result.Reverse();

            return string.Join("", result);
        }
    }
}
