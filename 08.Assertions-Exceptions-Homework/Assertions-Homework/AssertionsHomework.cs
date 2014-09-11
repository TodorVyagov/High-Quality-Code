using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    // Assertions are used to check the program logic and algorithm.
    // For some of these checks in this task(example: if element is outside of an array)
    // I think that is better to throw an exception, but most people made this
    // task only with Debug.Assert so I will do the same and will put comments,
    // where Exceptions are better solution.

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        //Invalid array
        Debug.Assert(arr != null, "Array cannot be null!"); //Exception
        Debug.Assert(arr.Length > 0, "Array cannot be empty!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // Check if array is correctly sorted.
        // Check is extracted in new method and in release version it will not
        // run the loop that is only used for assertion(check is slow).
        Debug.Assert(IsArraySorted(arr), "Array is not sorted!");
    }

    private static bool IsArraySorted<T>(T[] arr) where T : IComparable<T>
    {
        for (int index = 0; index < arr.Length - 1; index++)
        {
            //Checks if current element in array is greater than next element
            if (arr[index].CompareTo(arr[index + 1]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null!"); //Exception
        Debug.Assert(startIndex >= 0, "Start index in array cannot be negative!"); //Exception
        Debug.Assert(endIndex < arr.Length, "End index cannot be greater than given array lenght!"); //Exception
        Debug.Assert(startIndex < endIndex, "Start index cannot be greater or equal to end index!"); //Exception

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        //checks if this is the minimal element index in the array, again in new method
        Debug.Assert(IsMinimalElement(arr, minElementIndex, startIndex, endIndex),
            "This method is not correct to find the minimal element in array.");
        return minElementIndex;
    }

    private static bool IsMinimalElement<T>(T[] arr, int minIndex, int startIndex, int endIndex) where T : IComparable<T>
    {
        for (int index = startIndex + 1; index < endIndex; index++)
        {
            if (arr[minIndex].CompareTo(arr[index]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null!"); //Exception
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null!"); //Exception
        Debug.Assert(startIndex >= 0, "Start index in array cannot be negative"); //Exception
        Debug.Assert(endIndex < arr.Length, "End index cannot be greater than given array lenght"); //Exception
        Debug.Assert(startIndex < endIndex, "Start index cannot be greater or equal to end index!"); //Exception
        // we have to check if array is sorted!
        Debug.Assert(IsArraySorted(arr), "Array is not sorted and Binary search will not work correct!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Check if value exists, but is not returned! 
        Debug.Assert(!DoesElementExist(arr, value), "The element exists, but its index was not returned!");

        // Searched value not found
        return -1;
    }

    private static bool DoesElementExist<T>(T[] arr, T element) where T : IComparable<T>
    {
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index].CompareTo(element) == 0)
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        //Console.WriteLine(BinarySearch(arr, 3));
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        // Invokes Assert, because passes empty array and I commented it
        //SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
