namespace _01.SquareRoot
{
    using System;

    class Program
    {
        static void Main()
        {
            double number;
            try
            {
                number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
