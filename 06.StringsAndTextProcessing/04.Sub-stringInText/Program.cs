namespace _04.Sub_stringInText
{
    using System;

    class Program
    {
        static int CountAppearence(string text, string pattern)
        {
            pattern = pattern.ToLower();
            text = text.ToLower();
            int counter = 0;
            int startIndex = text.IndexOf(pattern);

            while (startIndex != -1)
            {
                counter++;
                startIndex = text.IndexOf(pattern, startIndex + 1);
            }

            return counter;
        }

        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            int patternAppearence = CountAppearence(text, pattern);

            Console.WriteLine(patternAppearence);
        }
    }
}
