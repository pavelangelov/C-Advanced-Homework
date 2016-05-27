namespace _04.TriangleSurfaceBySideAndAltitude
{
    using System;

    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            double surface = CalculateSurface(side, altitude);

            Console.WriteLine("{0:F2}", surface);

        }

        private static double CalculateSurface(double side, double altitude)
        {
            return (side * altitude) / 2;
        }
    }
}
