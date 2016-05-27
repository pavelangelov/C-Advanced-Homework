namespace _02.ReverseString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()
                                  .ToCharArray()
                                  .Reverse()
                                  .ToArray();

            Console.WriteLine(string.Join("", input));
        }
    }
}
