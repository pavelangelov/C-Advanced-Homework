namespace _01.AllocateArray
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = i * 5;
                Console.WriteLine(numbersArr[i]);
            } 
        }
    }
}
