using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrucrureDemo
{
    public class BubbleSort
    {
        public int[] bubble_sort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

       
    }
    public class BubbleSortExample : IExample
    {
        public void PrintResult()
        {
            int[] numbers = new int[] { 5, 1, 8, 3, 17, -6, 9 };
            Console.WriteLine("Before");
            foreach (var number in numbers)
            {
                Console.Write(number + "\t");
            }
            new BubbleSort().bubble_sort(numbers);
            Console.WriteLine();
            Console.WriteLine("After");
            Console.WriteLine();
            foreach (var number in numbers)
            {
                Console.Write(number + "\t");
            }

            Console.WriteLine();
        }
    }
}
