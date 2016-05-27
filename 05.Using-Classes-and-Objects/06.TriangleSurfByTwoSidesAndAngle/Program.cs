namespace _06.TriangleSurfByTwoSidesAndAngle
{
    using System;

    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double surface = SurfaceByTwoSidesAndAngle(a, b, angle);

            Console.WriteLine("{0:F2}", surface);
        }

        private static double SurfaceByTwoSidesAndAngle(double a, double b, double angle)
        {
            return (a * b * Math.Sin(Math.PI * angle / 180.0)) / 2;
        }
    }
}
