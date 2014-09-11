using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("All sides must be positive!");
            }

            if (!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentOutOfRangeException("The three given lines cannot form a triangle! a + b > c && a + c > b && b + c > a");
            }

            // p is half of the perimeter
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static string ConvertDigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid input! A digit must be given as parameter!");
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Invalid input! Input cannot be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Invalid input! Input cannot be an emprty array!");
            }

            int maximalNumber = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maximalNumber)
                {
                    maximalNumber = elements[i];
                }
            }

            return maximalNumber;
        }

        static void PrintTwoDigitsAfterDecimalSeparator(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintAsPercent(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintRightAlignedNumber(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static bool IsLineHorizontal(double y1, double y2)
        {
            bool isHorizontal = (y1 == y2);
            return isHorizontal;
        }

        static bool IsLineVertical(double x1, double x2)
        {
            bool isVertical = (x1 == x2);
            return isVertical;
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertDigitToWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintTwoDigitsAfterDecimalSeparator(13);
            PrintAsPercent(0.75);
            PrintRightAlignedNumber(2.30);

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            Console.WriteLine("Distance = " + CalculateDistance(x1, y1, x2, y2));
            bool isHorizontal = IsLineHorizontal(y1, y2);
            bool isVertical = IsLineVertical(x1, x2);
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", "17.03.1992");
            peter.OtherInfo = "From Sofia";

            Student stella = new Student("Stella", "Markova", "03.11.1993");
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("Peter's birth date is: " + peter.BirthDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("Stella's birth date is: " + stella.BirthDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("{0} is older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
