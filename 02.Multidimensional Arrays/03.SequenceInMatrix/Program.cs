namespace _03.SequenceInMatrix
{
    using System;

    class Program
    {
        private static string[] input = Console.ReadLine().Split(' ');
        private static int rows = int.Parse(input[0]);
        private static int cols = int.Parse(input[1]);
        private static string[,] matrix = new string[rows, cols];

        static void Main()
        {
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int longestSequence = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentStr = matrix[row, col];
                    int currentSequence = GetSequence(matrix, row, col, currentStr);
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }
                }
            }

            Console.WriteLine(longestSequence);
        }

        private static int GetSequence(string[,] matrix, int row, int col, string currentStr)
        {
            int currentSequence = 1;
            // Check for horizontal sequence

            if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] == currentStr)
            {
                int currentCol = col;
                do
                {
                    currentSequence++;
                    currentCol++;

                } while (currentCol < matrix.GetLength(1) - 1 && matrix[row, currentCol + 1] == currentStr);
                
            }
            // Check for vertical sequence;

            if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] == currentStr)
            {
                int currentRow = row;
                do
                {
                    currentSequence++;
                    currentRow++;

                } while (currentRow < matrix.GetLength(0) - 1 && matrix[currentRow + 1, col] == currentStr);
                
            }

            // Check for diagonal sequence in left

            if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] == currentStr)
            {
                int currentRow = row;
                int currentCol = col;
                do
                {
                    currentSequence++;
                    currentRow++;
                    currentCol++;

                } while (currentRow < matrix.GetLength(0) - 1 && currentCol < matrix.GetLength(1) - 1 && matrix[currentRow + 1, currentCol + 1] == currentStr);

            }

            // Check for diagonal sequence in right

            if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] == currentStr)
            {
                int currentRow = row;
                int currentCol = col;
                do
                {
                    currentSequence++;
                    currentRow++;
                    currentCol--;

                } while (currentRow < matrix.GetLength(0) - 1 && currentCol > 0 && matrix[currentRow + 1, currentCol - 1] == currentStr);
                
            }

            return currentSequence;
        }
    }
}
