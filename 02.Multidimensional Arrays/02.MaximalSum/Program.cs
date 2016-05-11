namespace _02.MaximalSum
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(line[j]);
                }
            }

            double sum = int.MinValue;
            double currentSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = CalculateSum(matrix, row, col);
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }

            Console.WriteLine(sum);
        }

        private static double CalculateSum(double[,] matrix, int startRow, int startCol)
        {
            double result = matrix[startRow, startCol] + matrix[startRow, startCol + 1] + matrix[startRow, startCol + 2] +
                         matrix[startRow + 1, startCol] + matrix[startRow + 1, startCol + 1] + matrix[startRow + 1, startCol + 2] +
                         matrix[startRow + 2, startCol] + matrix[startRow + 2, startCol + 1] + matrix[startRow + 2, startCol + 2];
            return result;
        }
    }
}
