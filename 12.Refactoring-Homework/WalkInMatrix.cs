namespace Matrix
{
    using System;

    public class WalkInMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
            //int n = 5;
            int[,] matrix = GenerateRotatingWalkMatrix(n);

            PrintMatrix(matrix);
        }

        static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirectionIndex = 0;

            for (int directionIndex = 0; directionIndex < directionsX.Length; directionIndex++)
            {
                if (directionsX[directionIndex] == dx && directionsY[directionIndex] == dy)
                {
                    currentDirectionIndex = directionIndex;
                    break;
                }
            }

            if (currentDirectionIndex == 7)
            {
                dx = directionsX[0];
                dy = directionsY[0];
                return;
            }

            dx = directionsX[currentDirectionIndex + 1];
            dy = directionsY[currentDirectionIndex + 1];
        }

        static bool CheckForNeighborEmptyCells(int[,] matrix, int col, int row)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int nextRow = 0;
            int nextCol = 0;

            for (int i = 0; i < directionsX.Length; i++)
            {
                nextCol = col + directionsX[i];
                if (nextCol >= matrix.GetLength(1) || nextCol < 0)
                {
                    directionsX[i] = 0;
                }

                nextRow = row + directionsY[i];
                if (nextRow >= matrix.GetLength(0) || nextRow < 0)
                {
                    directionsY[i] = 0;
                }

                if (matrix[col + directionsX[i], row + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindFirstEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }
                
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static int[,] GenerateRotatingWalkMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int number = 1;
            int col = 0;
            int row = 0;

            DoRotateWalkWhilePossible(matrix, n, ref col, ref row, ref number);

            number++;
            FindFirstEmptyCell(matrix, out col, out row);

            if (col != 0 && row != 0)
            {
                DoRotateWalkWhilePossible(matrix, n, ref col, ref row, ref number);
            }

            return matrix;
        }

        private static void DoRotateWalkWhilePossible(int[,] matrix, int n, ref int col, ref int row, ref int number)
        {
            int dx = 1;
            int dy = 1;

            while (true)
            {
                matrix[col, row] = number;

                if (!CheckForNeighborEmptyCells(matrix, col, row))
                {
                    // break when no empty cell is available at all directions
                    break;
                }

                while ((col + dx < 0 || col + dx >= n || row + dy < 0 || row + dy >= n || matrix[col + dx, row + dy] != 0))
                {
                    ChangeDirection(ref dx, ref dy);
                }

                col += dx;
                row += dy;
                number++;
            }
        }
    }
}
