namespace _18.RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int[] longest = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                longest[i] = 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (numbers[j] <= numbers[i] && longest[j] + 1 >= longest[i])
                    {
                        longest[i] = longest[j] + 1;
                    }
                    
                }
            }

            int maxSequence = 0;

            foreach (var item in longest)
            {
                if (maxSequence < item)
                {
                    maxSequence = item;
                }
            }

            Console.WriteLine(numbers.Length - maxSequence);
            
        }
    }
}
