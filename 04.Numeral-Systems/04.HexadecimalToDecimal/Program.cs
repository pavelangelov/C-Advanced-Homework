namespace _04.HexadecimalToDecimal
{
    using System;

    class Program
    {
        static void Main()
        {
            string hexadecimalNumber = Console.ReadLine();
            ulong decimalNumber = ConvertGromHexToDec(hexadecimalNumber);

            Console.WriteLine(decimalNumber);
        }

        private static ulong ConvertGromHexToDec(string hexadecimalNumber)
        {
            ulong result = 0;
            int pow = 0;
            for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
            {
                char symbol = hexadecimalNumber[i];
                ulong value = GetValueOfBit(symbol);
                result += value * Pow(16, pow);
                pow++;
            }

            return result;
        }

        private static ulong Pow(ulong v, int pow)
        {
            ulong result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= v;
            }
            return result;
        }

        private static ulong GetValueOfBit(char symbol)
        {
            ulong value = 0;
            switch (symbol)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    value = (ulong)(symbol - '0');
                    break;
                case 'A':
                    value = 10; break;
                case 'B':
                    value = 11; break;
                case 'C':
                    value = 12; break;
                case 'D':
                    value = 13; break;
                case 'E':
                    value = 14; break;
                case 'F':
                    value = 15; break;
                default:
                    break;
            }

            return value;
        }
    }
}
