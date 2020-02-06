using System;
using System.Runtime.InteropServices.ComTypes;

namespace DataStrucrureDemo
{
    public class BinarySearch
    {
        public int? DoNonRecursiveBinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length-1;
            while (min <= max)
            {
                int mid = (int)(min + max) / 2;
                if (key == inputArray[mid])
                    return ++mid;
                if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            return null;

        }

        public int? DoRecursiveBinarySearch(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
                return null;

            int mid = (int) (min + max) / 2;
            if (key == inputArray[mid])
                return ++mid;
            if (key < inputArray[mid])
            {
                max = mid - 1;
                return DoRecursiveBinarySearch(inputArray, key, min, max);
            }
            min = mid + 1;
            return DoRecursiveBinarySearch(inputArray, key, min, max);


        }
    }

    public class BinarySearchExample : IExample
    {
        public void PrintResult()
        {
            var result=new BinarySearch();
            var numbers = new int[4] { 23,34,56,66 };

            int? keyPosition = result.DoNonRecursiveBinarySearch(numbers, 34);
            Console.WriteLine($"Element found at non recursive position:{keyPosition ?? -1}");

            keyPosition = result.DoNonRecursiveBinarySearch(numbers, 56);
            Console.WriteLine($"Element found at recursive position:{keyPosition ?? -1}");
        }
    }
}
