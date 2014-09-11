using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
    public class Minesweeper
    {
        public class Point
        {
            string name;
            int points;
            
            public Point() { }

            public Point(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }

        static void Main(string[] args)
        {
            const int MAX = 35;

            string command = string.Empty;
            int counter = 0;
            int row = 0;
            int column = 0;
            bool isBoomed = false;
            bool isDead = true; 
            bool isWinner = false; // 
            char[,] field = CreatePlayground();
            char[,] bombs = PutBombs();
            List<Point> champions = new List<Point>(6);

            do
            {
                if (isDead)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck to find the fields wthout mines." +
                    " Command 'top' shows scores, 'restart' begins new game, 'exit' exits!");
                    DrawField(field);
                    isDead = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && 
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowScores(champions);
                        break;
                    case "restart":
                        field = CreatePlayground();
                        bombs = PutBombs();
                        DrawField(field);
                        isBoomed = false;
                        isDead = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye-Bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                YourTurn(field, bombs, row, column);
                                counter++;
                            }

                            if (MAX == counter)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DrawField(field);
                            }
                        }
                        else
                        {
                            isBoomed = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isBoomed)
                {
                    DrawField(bombs);
                    Console.Write("\nHrrrrrr! You are dead with {0} points. " + "Enter you name: ", counter);
                    string nickName = Console.ReadLine();
                    Point t = new Point(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Point playerOne, Point playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    champions.Sort((Point playerOne, Point playerTwo) => playerTwo.Points.CompareTo(playerOne.Points));
                    ShowScores(champions);

                    field = CreatePlayground();
                    bombs = PutBombs();
                    counter = 0;
                    isBoomed = false;
                    isDead = true;
                }
                if (isWinner)
                {
                    Console.WriteLine("\nBRAVOOO! You've opened 35 cells without being touched.");
                    DrawField(bombs);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Point points = new Point(name, counter);
                    champions.Add(points);
                    ShowScores(champions);
                    field = CreatePlayground();
                    bombs = PutBombs();
                    counter = 0;
                    isWinner = false;
                    isDead = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ShowScores(List<Point> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Scorecoard is still empty!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char numberOfBombs = MinesCount(bombs, row, column);
            bombs[row, column] = numberOfBombs;
            field[row, column] = numberOfBombs;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayground()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] playground = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playground[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>(); 
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!bombs.Contains(randomNumber))
                {
                    bombs.Add(randomNumber);
                }
            }

            foreach (int bomb in bombs)
            {
                int row = (bomb / columns);
                int col = (bomb % columns);
                if (col == 0 && bomb != 0)
                {
                    row--;
                    col = columns;
                }
                else
                {
                    col++;
                }

                playground[row, col - 1] = '*';
            }

            return playground;
        }

        private static void Calculations(char[,] field)
        {
            int row = field.GetLength(0);
            int col = field.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char count = MinesCount(field, i, j);
                        field[i, j] = count;
                    }
                }
            }
        }

        private static char MinesCount(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
