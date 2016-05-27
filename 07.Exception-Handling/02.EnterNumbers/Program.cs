namespace _02.EnterNumbers
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> numbers =  ReadNumber(0, 10);

            try
            {
                Print(numbers);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Exception");
            }
        }

        private static void Print(List<int> numbers)
        {
            StringBuilder result = new StringBuilder("1");
            int lastNum = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (lastNum < numbers[i] && numbers[i] < 100)
                {
                    result.Append(" < " + numbers[i]);
                }
                else
                {
                    throw new ArgumentException();
                }

                lastNum = numbers[i];
            }

            result.Append(" < 100");
            Console.WriteLine(result);

            
        }

        private static List<int> ReadNumber(int start, int end)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i < end; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            return numbers;
        }
    }
}
