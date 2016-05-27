namespace _10.UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static Dictionary<string, string> EscSeqDicitonary =
            new Dictionary<string, string>()
            {
                {@"\a", "0007" },
                {@"\b", "0008" },
                {@"\f", "000C" },
                {@"\n", "000A" },
                {@"\r", "000D" },
                {@"\t", "0009" },
                {@"\v", "000B" }
            };
        static void Main()
        {
            string input = Console.ReadLine();
            string unicodeSequence = ConvertStringToUnicodeSeq(input);

            Console.WriteLine(unicodeSequence);
        }

        private static string ConvertStringToUnicodeSeq(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == '\\')
                {
                    result.Append("\\u");
                    string key;
                    EscSeqDicitonary.TryGetValue("\\" + text[i + 1], out key);
                    result.Append(key);
                    i++;
                }
                else
                {
                    result.Append("\\u");
                    result.Append(String.Format("{0:X4}", (int)c));
                }
            }

            return result.ToString();
        }
    }
}
