namespace _14.QuickSort
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

            Quicksort(numbers, 0, numbers.Length - 1);

            Console.WriteLine(string.Join("\n", numbers));
        }

        private static void Quicksort(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = numbers[(left + right) / 2];
            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
 
                while (numbers[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
 
                if (i <= j)
                {
                    // Swap
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
 
                    i++;
                    j--;
                }
            }
 
            // Recursive calls
            if (left < j)
            {
                Quicksort(numbers, left, j);
            }
 
            if (i < right)
            {
                Quicksort(numbers, i, right);
            }

        }
    }
}
