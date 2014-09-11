namespace AdvancedMathOperationsTest
{
    using System;
    using System.Diagnostics;

    public static class SqrtTests
    {
        public const int NUMBER_OF_REPEATINGS = 1000000;

        public static Stopwatch FloatTest(float number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                Math.Sqrt(number);
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
                Math.Sqrt(number);
            }

            stopwatch.Stop();

            return stopwatch;
        }

        public static Stopwatch DecimalTest(decimal number)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < NUMBER_OF_REPEATINGS; i++)
            {
                Math.Sqrt((double)number);
            }

            stopwatch.Stop();

            return stopwatch;
        }
    }
}
