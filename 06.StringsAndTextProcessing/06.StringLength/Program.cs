namespace _06.StringLength
{
    using System;

    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine()
                                      .Replace("\\", String.Empty)
                                      .PadRight(20, '*');

            Console.WriteLine(inputText);
        }
    }
}
