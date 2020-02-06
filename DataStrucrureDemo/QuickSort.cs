using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrucrureDemo
{
    public class QuickSort
    {
        public void quick_sort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                var pivot = partition(numbers, left, right);
                if(pivot>1)
                    quick_sort(numbers,left,pivot-1);
                if(pivot+1<right)
                    quick_sort(numbers, pivot+1,right);
            }
        }
        private int partition(int[] numbers, int left, int right)
        {
            var pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] >pivot)
                    right--;
                if(left<right)
                {
                    if (numbers[left] == numbers[right]) return right;

                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }

    public class QuickSortExample : IExample
    {
        public void PrintResult()
        {
            int[] numbers = new int[] {5,1,8,3,17,-6,9 };
            Console.WriteLine("Before");
            foreach (var number in numbers)
            {
                Console.Write(number + "\t");
            }
            new QuickSort().quick_sort(numbers,0,numbers.Length-1);
            Console.WriteLine();
            Console.WriteLine("After");
            Console.WriteLine();
            foreach (var number in numbers)
            {
                Console.Write(number+"\t");
            }

            Console.WriteLine();
        }
    }
}
