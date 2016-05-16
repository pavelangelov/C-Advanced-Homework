namespace _05.HexadecimalToBinary
{
    using System;
    using System.Text;
    class Program
    {
        static void Main()
        {
            string hexadecimalNumber = Console.ReadLine();
            string binaryRepresent = ConvertFromHexToBin(hexadecimalNumber);

            Console.WriteLine(binaryRepresent);
        }

        private static string ConvertFromHexToBin(string hexadecimalNumber)
        {
            StringBuilder result = new StringBuilder();
            result.Append(GetFirstIndexValue(hexadecimalNumber[0]));
            for (int i = 1; i < hexadecimalNumber.Length; i++)
            {
                char symbol = hexadecimalNumber[i];
                result.Append(GetBinaryValue(symbol));
            }

            return result.ToString();
        }

        private static string GetFirstIndexValue(char symbol)
        {
            string result = "";
            switch (symbol)
            {
                case '0': result = "0"; break;
                case '1': result = "1"; break;
                case '2': result = "10"; break;
                case '3': result = "11"; break;
                case '4': result = "100"; break;
                case '5': result = "101"; break;
                case '6': result = "110"; break;
                case '7': result = "111"; break;
                case '8': result = "1000"; break;
                case '9': result = "1001"; break;
                case 'A': result = "1010"; break;
                case 'B': result = "1011"; break;
                case 'C': result = "1100"; break;
                case 'D': result = "1101"; break;
                case 'E': result = "1110"; break;
                case 'F': result = "1111"; break;
                default:
                    break;
            }

            return result;
        }

        private static string GetBinaryValue(char symbol)
        {
            string result = "";
            switch (symbol)
            {
                case '0': result = "0000"; break;
                case '1': result = "0001"; break;
                case '2': result = "0010"; break;
                case '3': result = "0011"; break;
                case '4': result = "0100"; break;
                case '5': result = "0101"; break;
                case '6': result = "0110"; break;
                case '7': result = "0111"; break;
                case '8': result = "1000"; break;
                case '9': result = "1001"; break;
                case 'A': result = "1010"; break;
                case 'B': result = "1011"; break;
                case 'C': result = "1100"; break;
                case 'D': result = "1101"; break;
                case 'E': result = "1110"; break;
                case 'F': result = "1111"; break;
                default:
                    break;
            }

            return result;
        }
    }
}
