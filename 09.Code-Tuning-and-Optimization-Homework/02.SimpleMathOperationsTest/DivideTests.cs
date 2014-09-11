namespace SimpleMathOperationsTest
{
    using System.Diagnostics;

    public static class DivideTests
    {
        public const int NUMBER_OF_REPEATINGS = 1000000;

        public static Stopwatch IntTest(int number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                number = number / 5;

            }

            stopwatch.Stop();
            return stopwatch;
        }

        public static Stopwatch LongTest(long number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                number = number / 5;
            }

            stopwatch.Stop();

            return stopwatch;
        }

        public static Stopwatch FloatTest(float number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                number = number / 5;
            }

            stopwatch.Stop();

            return stopwatch;
        }

        public static Stopwatch DoubleTest(double number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                number = number / 5;
            }

            stopwatch.Stop();

            return stopwatch;
        }

        public static Stopwatch DecimalTest(decimal number)
        {
            Stopwatch stopwatch = new Stopwatch();
            decimal testNumber;
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                testNumber = number / 5;
            }

            stopwatch.Stop();

            return stopwatch;
        }
    }
}
