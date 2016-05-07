namespace _15.PrimeNumbers
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] notPrimeNumbers = new bool[n + 1];
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (notPrimeNumbers[i] == false)
                {
                    for (int j = i * i; j <= n; j+=i)
                    {
                        notPrimeNumbers[j] = true;
                    }
                }
            }

            Console.WriteLine(Array.LastIndexOf(notPrimeNumbers, false));

        }
    }
}
