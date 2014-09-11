namespace RefactorLoop
{
    using System;

    class RefactorLoop
    {
        static void Main(string[] args)
        {
            // Refactor the following loop: 
            // Added some code to be able to build the project.
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            int expectedValue = 61;
            //End of added code

            bool isValueFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                        break; // if value is found we should break the cycle
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            // More code here

            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
