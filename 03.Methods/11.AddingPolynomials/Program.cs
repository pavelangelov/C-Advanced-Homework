namespace _11.AddingPolynomials
{
    using System;

    class Program
    {
        private static int n = int.Parse(Console.ReadLine());
        private static string[] firstPolynomial = Console.ReadLine().Split(' ');
        private static string[] secondPolynomial = Console.ReadLine().Split(' ');

        static void Main()
        {
            int[] result = new int[n];
            result = SumOfPolynomials(result);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] SumOfPolynomials(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(firstPolynomial[i]) + int.Parse(secondPolynomial[i]);
            }

            return result;
        }
    }
}
