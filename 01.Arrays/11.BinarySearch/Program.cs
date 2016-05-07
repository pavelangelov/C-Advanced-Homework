namespace _11.BinarySearch
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

            int searchedNum = int.Parse(Console.ReadLine());
            bool found = false;
            int length = numbers.Length;
            int index = length / 2;
            while (true)
            {
                int current = numbers[index];
                if (searchedNum > current)
                {
                    length /= 2;
                    index = index + (length / 2);
                }
                else if (searchedNum < current)
                {
                    length /= 2;
                    index = index - (length / 2);
                }
                else
                {
                    found = true;
                    break;
                }

                if (length == 0)
                {
                    break;
                }
            }

            Console.WriteLine(found ? index : -1);
        }
    }
}
