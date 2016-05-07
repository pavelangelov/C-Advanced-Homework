namespace _13.MergeSort
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            List<int> result = MergeSort(numbers);
            Console.WriteLine(string.Join("\n", result));

        }

        static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    rightSide.Add(list[i]);
                }
                else
                {
                    leftSide.Add(list[i]);
                }
            }

            leftSide = MergeSort(leftSide);
            rightSide = MergeSort(rightSide);

            return Merge(leftSide, rightSide);
        }

        private static List<int> Merge(List<int> leftSide, List<int> rightSide)
        {
            List<int> result = new List<int>();
            while (leftSide.Count > 0 && rightSide.Count > 0)
            {
                if (leftSide[0] <= rightSide[0])
                {
                    result.Add(leftSide[0]);
                    leftSide.RemoveAt(0);
                }
                else
                {
                    result.Add(rightSide[0]);
                    rightSide.RemoveAt(0);
                }
            }

            while (leftSide.Count > 0)
            {
                result.Add(leftSide[0]);
                leftSide.RemoveAt(0);
            }

            while (rightSide.Count > 0)
            {
                result.Add(rightSide[0]);
                rightSide.RemoveAt(0);
            }

            return result;
        }
    }
}
