namespace _07.OneSystemToAnyOther
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static int sNumeralSystem = int.Parse(Console.ReadLine());
        private static string numberInSNumericSystem = Console.ReadLine();
        private static char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private static int dNumeralSystem = int.Parse(Console.ReadLine());

        static void Main()
        {
            long numberInDec = ConvertFromXToDec(numberInSNumericSystem);
            string numberInDNumSystem = ConvertFromDecToXNumSystem(numberInDec);

            Console.WriteLine(numberInDNumSystem);
        }

        private static string ConvertFromDecToXNumSystem(long number)
        {
            List<string> result = new List<string>();
            while (number > 0)
            {
                long remainder = number % dNumeralSystem;
                string value = symbols[remainder].ToString();
                result.Add(value);
                number /= dNumeralSystem;
            }

            result.Reverse();

            return string.Join("", result);
        }

        private static long ConvertFromXToDec(string numInXNumSystem)
        {
            long result = 0;
            int pow = 0;
            for (int i = numInXNumSystem.Length - 1; i >= 0; i--)
            {
                int bitValue = Array.IndexOf(symbols, numInXNumSystem[i]);
                result += bitValue * Pow(sNumeralSystem, pow);
                pow++;
            }

            return result;
        }

        private static long Pow(int sNumeralSystem, int pow)
        {
            long result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= sNumeralSystem;
            }

            return result;
        }
    }
}
