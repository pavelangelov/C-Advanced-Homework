namespace _03.EnglishDigit
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string lastDigit = GetLastDigit(number);

            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigit(int number)
        {
            string result = "";
            switch (number % 10)
            {
                case 0:
                    result = "zero"; break;
                case 1:
                    result = "one"; break;
                case 2:
                    result = "two"; break;
                case 3:
                    result = "three"; break;
                case 4:
                    result = "four"; break;
                case 5:
                    result = "five"; break;
                case 6:
                    result = "six"; break;
                case 7:
                    result = "seven"; break;
                case 8:
                    result = "eight"; break;
                case 9:
                    result = "nine"; break;
                default:
                    break;
            }

            return result;
        }
    }
}
