using System;
using System.Collections.Generic;

namespace DataStrucrureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // new _2ndHighestNum().GetMaxAndNextMaxNum(new List<int> {3,1,2,4 });
            new ShortNum().ShortNumbers(new List<int> { 3, 1, 2,99,78,96,43,11});
            Console.WriteLine("Hello World!");
            Console.WriteLine("=========================Binary Search=====================");
            new BinarySearchExample().PrintResult();
            Console.WriteLine("************************Binary Search***********************");
            Console.WriteLine("=========================Quick Sort=====================");
            new QuickSortExample().PrintResult();
            Console.WriteLine("************************Quick Sort***********************");
            Console.WriteLine("=========================Merge Sort=====================");
            new MergeSortExample().PrintResult();
            Console.WriteLine("************************Merge Sort***********************");
            Console.WriteLine("=========================Bubble Sort=====================");
            new BubbleSortExample().PrintResult();
            Console.WriteLine("************************Bubble Sort***********************");
            Console.ReadKey();
        }
    }
}
