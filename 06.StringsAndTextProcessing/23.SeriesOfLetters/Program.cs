namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string result = ReplaceIdenticalLetters(input);

            Console.WriteLine(result);
        }

        private static string ReplaceIdenticalLetters(string text)
        {
            StringBuilder result = new StringBuilder();
            char lastSymbol = text[0];
            result.Append(lastSymbol);
            for (int i = 1; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                if (currentSymbol == lastSymbol)
                {
                    continue;
                }

                result.Append(currentSymbol);
                lastSymbol = currentSymbol;
            }

            return result.ToString();
        }
    }
}
