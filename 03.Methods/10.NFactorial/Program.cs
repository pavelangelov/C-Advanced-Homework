namespace _10.NFactorial
{
    using System;
    using System.Numerics;

    class Program
    {
        private static int n = int.Parse(Console.ReadLine());

        static void Main()
        {
            BigInteger factoriel = CalculateFactoriel(n);

            Console.WriteLine(factoriel);
        }

        private static BigInteger CalculateFactoriel(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * CalculateFactoriel(n - 1);
        }
    }
}
