namespace _07.LargestAreaInMatrix
{
    using System;

    class Program
    {

        private static string[] input = Console.ReadLine().Split(' ');
        private static int rows = int.Parse(input[0]);
        private static int cols = int.Parse(input[1]);
        private static int[,] matrix = new int[rows, cols];
        private static bool[,] usedNumbers = new bool[rows, cols];
        private static int largestArea = 0;
        public static int maxSiquence = 0;

        static void Main()
        {
            matrix = InitInt32Matrix(matrix, rows, cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int currentNum = matrix[row, col];
                    CheckForChildren(row, col, currentNum);
                    if (maxSiquence < largestArea)
                    {
                        maxSiquence = largestArea;
                    }
                    largestArea = 0;
                }
            }

            Console.WriteLine(maxSiquence);
        }

        private static void CheckForChildren(int row, int col, int number)
        {
            largestArea++;
            usedNumbers[row, col] = true;

            // Check right cell
            if (col < matrix.GetLength(1) - 1 && usedNumbers[row, col + 1] == false && matrix[row, col + 1] == number)
            {
                CheckForChildren(row, col + 1, number);
            }

            // Check left cell
            if (col > 0 && usedNumbers[row, col - 1] == false && matrix[row, col - 1] == number)
            {
                CheckForChildren(row, col - 1, number);
            }

            // Check down cell
            if (row < matrix.GetLength(0) - 1 && usedNumbers[row + 1, col] == false && matrix[row + 1, col] == number)
            {
                CheckForChildren(row + 1, col, number);
            }

            // Check up cell
            if (row > 0 && usedNumbers[row - 1, col] == false && matrix[row - 1, col] == number)
            {
                CheckForChildren(row - 1, col, number);
            }

            
        }

        private static int[,] InitInt32Matrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            return matrix;
        }
    }
}
