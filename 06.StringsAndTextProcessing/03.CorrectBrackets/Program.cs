namespace _03.CorrectBrackets
{
    using System;

    class Program
    {
        static int CountReplayerSymbols(string text, char symbol)
        {
            int symbolCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    symbolCounter++;
                }
            }

            return symbolCounter;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            int openBrackets = CountReplayerSymbols(input, '(');
            int closedBrackets = CountReplayerSymbols(input, ')');

            Console.WriteLine(openBrackets == closedBrackets ? "Correct" : "Incorrect");
        }
    }
}
