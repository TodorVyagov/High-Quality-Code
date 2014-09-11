// Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.

namespace AdvancedMathOperationsTest
{
    using System;

    class AdvancedMathOperationsTest
    {

        static void Main(string[] args)
        {

            float floatNumber = 10.299f;
            double doubleNumber = 10.299d;
            decimal decimalNumber = 10.299m;

            // Test square root:
            Console.WriteLine("Testing Square root:");
            Console.WriteLine("Float Elapsed time: " + SqrtTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: " + SqrtTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: " + SqrtTests.DecimalTest(decimalNumber).Elapsed);

            // Test natural logarithm
            Console.WriteLine("\nTesting natural logarithm:");
            Console.WriteLine("Float Elapsed time: " + NaturalLogarithmTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: " + NaturalLogarithmTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: " + NaturalLogarithmTests.DecimalTest(decimalNumber).Elapsed);
            Console.WriteLine("The cast makes decimal slowest.");
            
            // Test sinus
            Console.WriteLine("\nTesting sinus:");
            Console.WriteLine("Float Elapsed time: " + SinusTests.FloatTest(floatNumber).Elapsed);
            Console.WriteLine("Double Elapsed time: " + SinusTests.DoubleTest(doubleNumber).Elapsed);
            Console.WriteLine("Decimal Elapsed time: " + SinusTests.DecimalTest(decimalNumber).Elapsed);
        }

        
    }
}
