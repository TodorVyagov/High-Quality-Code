using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (startIndex < 0)
        {
            throw new IndexOutOfRangeException("Start index cannot be negative!");
        }

        if (startIndex + count >= arr.Length)
        {
            throw new IndexOutOfRangeException("Start index + count cannot be equal or greater than given array.Length");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("Count cannot be negative!");
        }

        if (count > str.Length)
        {
            throw new IndexOutOfRangeException("Count cannot be greater than given array.Length");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool IsPrime(int number)
    {
        //here we can check if number is integer, but the method parameter is int32 and floating point number cannot be passed as parameter

        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("Prime number must be non negative integer greater than 1.");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        //var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4); //Throws an exception
        //Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        //Console.WriteLine(ExtractEnding("Hi", 100)); //Throws an exception

        Console.WriteLine("23 is {0}prime.", IsPrime(23) ? "" : "not ");

        Console.WriteLine("33 is {0}prime.", IsPrime(33) ? "" : "not ");

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
