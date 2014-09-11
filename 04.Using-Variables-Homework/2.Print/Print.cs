namespace Print
{
    using System;

    public class Print
    {
        // Refactor the following code to apply variable usage and naming best practices:

        /// <summary>
        /// Prints the maximal, minimal and average value of given array of numbers.
        /// </summary>
        public void PrintStatistics(double[] numbers, int count) // I don't know why we need count when we have [].Length
        {
            // three tasks can be done with 1 for cycle, but here we have to see variable
            // live time and span, so I will not optimize it.
            double max = double.MinValue; // or = numbers[0]; if arr.length > 0
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            PrintMax(max);

            double min = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }
            PrintAverage(sum / count);
        }

        private void PrintMax(double max)
        {
            throw new NotImplementedException();
        }
               
        private void PrintMin(double min)
        {
            throw new NotImplementedException();
        }

        private void PrintAverage(double average)
        {
            throw new NotImplementedException();
        }
    }
}
