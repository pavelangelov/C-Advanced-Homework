namespace _15.ReplaceTags
{
    using System;
    using System.Text;

    class Program
    {
        private static string openTagToReplace = "<a href=\"";
        private static string closeTagToReplace = "</a>";
        

        static void Main()
        {

            string inputText = Console.ReadLine();

            string result = ReplaceTagsFromText(inputText);

            Console.WriteLine(result);
        }

        private static string ReplaceTagsFromText(string inputText)
        {
            StringBuilder result = new StringBuilder();
            int startIndex = 0;
            int openTagIndex = inputText.IndexOf(openTagToReplace);
            int closeTagIndex = inputText.IndexOf(closeTagToReplace);
            while (openTagIndex != -1 && closeTagIndex != -1)
            {
                // Append the part of the text before <a>
                result.Append(inputText.Substring(startIndex, openTagIndex - startIndex));
                result.Append("[");

                int hrefContentStart = openTagIndex + openTagToReplace.Length;
                int indexOfCloseQuote = inputText.IndexOf('"', hrefContentStart);
                int hrefContentLen = indexOfCloseQuote - hrefContentStart;
                string hrefContent = inputText.Substring(hrefContentStart, hrefContentLen);

                // Append the text fom the <a>
                result.Append(inputText.Substring(indexOfCloseQuote + 2, closeTagIndex - (indexOfCloseQuote + 2)));
                result.Append("](");
                result.Append(hrefContent);
                result.Append(")");

                startIndex = closeTagIndex + closeTagToReplace.Length;
                openTagIndex = inputText.IndexOf(openTagToReplace, startIndex);
                closeTagIndex = inputText.IndexOf(closeTagToReplace, startIndex);

                if (openTagIndex == -1)
                {
                    // If have no more <a> in the text, but have some text to append
                    result.Append(inputText.Substring(startIndex));
                }
            }

            return result.ToString();
        }
    }
}
