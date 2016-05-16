namespace _03.DecimalToHexadecimal
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            string hexadecimalResult = ConvertFromDecToHex(number);

            Console.WriteLine(hexadecimalResult);
        }

        private static string ConvertFromDecToHex(ulong number)
        {
            List<string> result = new List<string>();
            while (number > 0)
            {
                ulong remainder = number % 16;
                switch (remainder)
                {
                    case 0: result.Add("0"); break;
                    case 1: result.Add("1"); break;
                    case 2: result.Add("2"); break;
                    case 3: result.Add("3"); break;
                    case 4: result.Add("4"); break;
                    case 5: result.Add("5"); break;
                    case 6: result.Add("6"); break;
                    case 7: result.Add("7"); break;
                    case 8: result.Add("8"); break;
                    case 9: result.Add("9"); break;
                    case 10: result.Add("A"); break;
                    case 11: result.Add("B"); break;
                    case 12: result.Add("C"); break;
                    case 13: result.Add("D"); break;
                    case 14: result.Add("E"); break;
                    case 15: result.Add("F"); break;
                    default:
                        break;
                }
                number /= 16;
            }

            result.Reverse();
            return string.Join("", result);
        }
    }
}
