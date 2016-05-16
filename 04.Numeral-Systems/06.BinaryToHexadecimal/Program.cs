namespace _06.BinaryToHexadecimal
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string binaryRepresent = Console.ReadLine();
            string hexadecimalRepresent = ConvertFromBinToHex(binaryRepresent);

            Console.WriteLine(hexadecimalRepresent);

        }

        private static string ConvertFromBinToHex(string binaryRepresent)
        {
            List<string> result = new List<string>();
            while (binaryRepresent.Length > 4)
            {
                string lastFourBits = binaryRepresent.Substring(binaryRepresent.Length - 4);
                string hexadecimalValue = GetHexadecimalValue(lastFourBits);
                result.Add(hexadecimalValue);
                binaryRepresent = binaryRepresent.Substring(0, binaryRepresent.Length - 4);
            }

            result.Add(GetHexadecimalValue(binaryRepresent));

            result.Reverse();

            return string.Join("", result);
        }

        private static string GetHexadecimalValue(string lastFourBits)
        {
            string result = "";
            int pow = 0;
            int decimalResult = 0;
            for (int i = lastFourBits.Length - 1; i >= 0; i--)
            {
                int bitValue = lastFourBits[i] - '0';
                decimalResult += bitValue * Pow(2, pow);
                pow++;
            }

            if (decimalResult > 9)
            {
                switch (decimalResult)
                {
                    case 10: result = "A"; break;
                    case 11: result = "B"; break;
                    case 12: result = "C"; break;
                    case 13: result = "D"; break;
                    case 14: result = "E"; break;
                    case 15: result = "F"; break;
                    default:
                        break;
                }
            }
            else
            {
                result += decimalResult;
            }

            return result;

        }

        private static int Pow(int v, int pow)
        {
            int result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= v;
            }

            return result;
        }
    }
}
