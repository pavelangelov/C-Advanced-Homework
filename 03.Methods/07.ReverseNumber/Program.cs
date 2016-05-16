namespace _07.ReverseNumber
{
    using System;
    using System.Text;

    class Program
    {
        private static string numberStr = Console.ReadLine();

        static void Main()
        {
            string reversedNumber = ReverseString();

            Console.WriteLine(reversedNumber);
        }

        private static string ReverseString()
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                reversed.Append(numberStr[i].ToString());
            }

            return reversed.ToString();
        }
    }
}
