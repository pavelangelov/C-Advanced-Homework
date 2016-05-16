namespace _02.BinaryToDecimal
{
    using System;

    class Program
    {
        static void Main()
        {
            string binaryRepresent = Console.ReadLine();
            ulong decimalResult = ConvertFromBinToDec(binaryRepresent);

            Console.WriteLine(decimalResult);
        }

        private static ulong ConvertFromBinToDec(string binaryRepresent)
        {
            ulong result = 0;
            int pow = 0;
            for (int i = binaryRepresent.Length - 1; i >= 0; i--)
            {
                ulong bitValue = (ulong)((binaryRepresent[i] - '0'));
                result += bitValue * Pow(2, pow);
                pow++;
            }


            return result;
        }

        private static ulong Pow(int v, int pow)
        {
            ulong result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= (ulong)v;
            }

            return result;
        }
    }
}
