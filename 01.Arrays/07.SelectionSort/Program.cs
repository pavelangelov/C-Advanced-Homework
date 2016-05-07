namespace _07.SelectionSort
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue;
            int index = -1;
            int currentValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        index = j;
                    }
                }
                if (index >= 0)
                {
                    currentValue = numbers[i];
                    numbers[i] = min;
                    numbers[index] = currentValue;
                }

                min = int.MaxValue;
                index = -1;
                
            }

            Console.WriteLine(string.Join("\n", numbers));
        }
    }
}
