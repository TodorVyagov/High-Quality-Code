// Write a program to compare the performance of add, subtract, increment, multiply,
// divide for int, long, float, double and decimal values.

namespace SimpleMathOperationsTest
{
    using System;

    class SimpleMathOperationsTest
    {
        static void Main()
        {
            int intNumber = 10;
            long longNumber = 10;
            float floatNumber = 10.299f;
            double doubleNumber = 10.299d;
            decimal decimalNumber = 10.299m;

            // Test add
            Console.WriteLine("Testing add:");
            Console.WriteLine("Int Elapsed time: {0,20}", AddTests.IntTest(intNumber).Elapsed);
            Console.WriteLine("Long Elapsed time: {0,19}", AddTests.LongTest(longNumber).Elapsed);
            Console.WriteLine("Float Elapsed time: {0,18}", AddTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: {0,17}", AddTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: {0,16}", AddTests.DecimalTest(decimalNumber).Elapsed);

            // Test subtract
            Console.WriteLine("\nTesting subtract:");
            Console.WriteLine("Int Elapsed time: {0,20}", SubtractTests.IntTest(intNumber).Elapsed);
            Console.WriteLine("Long Elapsed time: {0,19}", SubtractTests.LongTest(longNumber).Elapsed);
            Console.WriteLine("Float Elapsed time: {0,18}", SubtractTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: {0,17}", SubtractTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: {0,16}", SubtractTests.DecimalTest(decimalNumber).Elapsed);

            // test increment
            Console.WriteLine("\nTesting increment:");
            Console.WriteLine("Int Elapsed time: {0,20}", IncrementTests.IntTest(intNumber).Elapsed);
            Console.WriteLine("Long Elapsed time: {0,19}", IncrementTests.LongTest(longNumber).Elapsed);
            Console.WriteLine("Float Elapsed time: {0,18}", IncrementTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: {0,17}", IncrementTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: {0,16}", IncrementTests.DecimalTest(decimalNumber).Elapsed);

            // test multiply
            Console.WriteLine("\nTesting multiply:");
            Console.WriteLine("Int Elapsed time: {0,20}", MultiplyTests.IntTest(intNumber).Elapsed);
            Console.WriteLine("Long Elapsed time: {0,19}", MultiplyTests.LongTest(longNumber).Elapsed);
            Console.WriteLine("Float Elapsed time: {0,18}", MultiplyTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: {0,17}", MultiplyTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: {0,16}", MultiplyTests.DecimalTest(decimalNumber).Elapsed);

            //test divide
            Console.WriteLine("\nTesting divide:");
            Console.WriteLine("Int Elapsed time: {0,20}", DivideTests.IntTest(intNumber).Elapsed);
            Console.WriteLine("Long Elapsed time: {0,19}", DivideTests.LongTest(longNumber).Elapsed);
            Console.WriteLine("Float Elapsed time: {0,18}", DivideTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: {0,17}", DivideTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: {0,16}", DivideTests.DecimalTest(decimalNumber).Elapsed);
        }
    }
}
