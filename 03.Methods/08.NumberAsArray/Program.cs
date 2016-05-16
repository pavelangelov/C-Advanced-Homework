namespace _08.NumberAsArray
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static string[] input = Console.ReadLine().Split(' ');
        private static int firstArrLen = int.Parse(input[0]);
        private static int secondArrLen = int.Parse(input[1]);
        private static List<int> result = new List<int>();

        static void Main()
        {
            int biggerLen = Math.Max(firstArrLen, secondArrLen);
            int smallerLen = Math.Min(firstArrLen, secondArrLen);

            int[] firstIntArr = new int[biggerLen];
            int[] secondIntArr = new int[smallerLen];
            if (firstArrLen > secondArrLen)
            {
                InitArr(firstIntArr);
                InitArr(secondIntArr);
            }
            else
            {
                InitArr(secondIntArr);
                InitArr(firstIntArr);
            }

            CalculateArrSum(firstIntArr, secondIntArr);

            Console.WriteLine(string.Join(" ", result));
        }

        private static void CalculateArrSum(int[] firstArr, int[] secondArr)
        {
            int remainder = 0;
            int lastCalculatedIndex = -1;
            for (int i = 0; i < secondArr.Length; i++)
            {
                int currentSum = firstArr[i] + secondArr[i] + remainder;
                int value;
                if (currentSum > 9)
                {
                    value = currentSum - 10;
                    remainder = 1;
                }
                else
                {
                    value = currentSum;
                    remainder = 0;
                }
                result.Add(value);
                lastCalculatedIndex = i;
            }

            if (lastCalculatedIndex >= 0 && lastCalculatedIndex < firstArr.Length - 1 )
            {
                for (int i = lastCalculatedIndex + 1; i < firstArr.Length; i++)
                {
                    int currentSum = firstArr[i] + remainder;
                    int value;
                    if (currentSum > 9)
                    {
                        value = currentSum - 10;
                        remainder = 1;
                    }
                    else
                    {
                        value = currentSum;
                        remainder = 0;
                    }
                    result.Add(value);
                }
            }

            if (remainder > 0)
            {
                result.Add(remainder);
            }
        }

        private static void InitArr(int[] arr)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(line[i]);
            }
        }
    }
}
