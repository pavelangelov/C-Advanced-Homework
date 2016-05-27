namespace _05.TriangleSurfaceByThreeSides
{
    using System;

    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());


            double surface = SurfaceByThreeSides(a, b, c);

            Console.WriteLine("{0:F2}", surface);
        }

        private static double SurfaceByThreeSides(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double surface = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return surface;
        }
    }
}
