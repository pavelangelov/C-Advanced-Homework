namespace _01.SayHello
{
    using System;

    class Program
    {
        static void Main()
        {
            string name = GetName();
            Console.WriteLine("Hello, {0}!", name);
        }

        private static string GetName()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
