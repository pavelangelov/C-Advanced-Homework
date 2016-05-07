namespace _02.CompareArrays
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            bool areEqual = true;
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
