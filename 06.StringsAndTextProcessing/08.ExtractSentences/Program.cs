namespace _08.ExtractSentences
{

    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            List<string> sentences = ExtractSentencesContainedWord(text, word);

            Console.WriteLine(string.Join("", sentences));
        }

        static char[] CheckForNonLetterSymbol(string text)
        {
            List<char> nonLetters = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]) && !nonLetters.Contains(text[i]))
                {
                    nonLetters.Add(text[i]);
                }
            }

            return nonLetters.ToArray();
        }

        private static List<string> ExtractSentencesContainedWord(string text, string word)
        {
            string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();
            for (int i = 0; i < sentences.Length; i++)
            {
                string currentSentence = sentences[i];
                char[] nonLetterSymbols = CheckForNonLetterSymbol(currentSentence);

                string[] sentence = currentSentence.Split(nonLetterSymbols, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < sentence.Length; j++)
                {
                    if (sentence[j].ToLower().Trim() == word.ToLower())
                    {
                        result.Add(currentSentence.Trim() + ". ");
                        break;
                    }
                }
            }

            return result;
        }
    }
}
