namespace _01.FillTheMatrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[,] matrix = new int[n, n];
            switch (input)
            {
                case "a":
                    matrix = FillMatrixUpToDown(matrix);
                    break;
                case "b":
                    matrix = FillMatrixZigZag(matrix);
                    break;
                case "c":
                    matrix = FillMatrix(matrix);
                    break;
                case "d":
                    matrix = FillSpiralMatrix(matrix);
                    break;
                default:
                    break;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
        }

        private static int[,] FillMatrix(int[,] matrix)
        {
            int numberOfSymbols = matrix.GetLength(0) * matrix.GetLength(1);

            // For this case I split the matrix to 2 rectangles. For the first one I started from bottom-left angle.

            int row = matrix.GetLength(0) - 1;
            int col = 0;
            int nextRow = row - 1;
            int number = 1;
            while (row >= 0)
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
                if (row > matrix.GetLength(0) - 1 ||  col > matrix.GetLength(1) - 1)
                {
                    row = nextRow;
                    col = 0;
                    nextRow = row - 1;
                }
            }

            // For the second rectangle, the start positions is the top-left empty index.
            row = 0;
            col = 1;
            int nextCol = col + 1;
            while (number <= numberOfSymbols)
            {
                matrix[row, col] = number;
                row++;
                col++;
                number++;
                if (col > matrix.GetLength(1) - 1 || matrix[row, col] > 0)
                {
                    row = 0;
                    col = nextCol;
                    nextCol = col + 1;
                }
            }


            return matrix;
        }

        private static int[,] FillMatrixZigZag(int[,] matrix)
        {
            int numberOfSymbols = matrix.GetLength(0) * matrix.GetLength(1);
            int row = 0;
            int col = 0;
            string direction = "down";
            for (int i = 1; i <= numberOfSymbols; i++)
            {
                if (direction == "down" && row > matrix.GetLength(0) - 1)
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && row < 0)
                {
                    direction = "down";
                    row++;
                    col++;
                }

                matrix[row, col] = i;
                if (direction == "down")
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixUpToDown(int[,] matrix)
        {
            int numberOfSymbols = matrix.GetLength(0) * matrix.GetLength(1);
            int row = 0;
            int col = 0;
            for (int i = 1; i <= numberOfSymbols; i++)
            {
                if (row > matrix.GetLength(0) - 1)
                {
                    col++;
                    row = 0;
                }
                matrix[row, col] = i;
                row++;
            }


            return matrix;
        }

        private static int[,] FillSpiralMatrix(int[,] matrix)
        {
            int numberOfSymbols = matrix.GetLength(0) * matrix.GetLength(1);
            int row = 0;
            int col = 0;
            string direction = "down";
            for (int i = 1; i <= numberOfSymbols; i++)
            {
                if (direction == "right" && (col > matrix.GetLength(1) - 1 || matrix[row, col] > 0))
                {
                    row--;
                    col--;
                    direction = "up";

                }
                if (direction == "up" && (row < 0 || matrix[row, col] > 0))
                {
                    col--;
                    row++;
                    direction = "left";
                }
                if (direction == "left" && (col < 0 || matrix[row, col] > 0))
                {
                    row++;
                    col++;
                    direction = "down";
                }
                if (direction == "down" && (row > matrix.GetLength(0) - 1 || matrix[row, col] > 0))
                {
                    row--;
                    col++;
                    direction = "right";
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                else if (direction == "up")
                {
                    row--;
                }
                else if (direction == "left")
                {
                    col--;
                }
                else if (direction == "down")
                {
                    row++;
                }
            }

            return matrix;
        }
    }
}
