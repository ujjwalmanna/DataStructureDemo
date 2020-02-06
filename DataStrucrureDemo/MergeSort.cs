using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStrucrureDemo
{
    public class MergeSort
    {
        public List<int> DoSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = DoSort(left);
            right = DoSort(right);
            return Merge(left, right);
        }
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> output = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() < right.First())
                    {
                        output.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        output.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    output.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    output.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return output;

        }
    }

    public class MergeSortExample : IExample
    {
        public void PrintResult()
        {
            List<int> numbersList = new List<int> { 12, 1,-2, 8, 3, 17, -6, 9 };
            Console.WriteLine("Before");
            foreach (var number in numbersList)
            {
                Console.Write(number + "\t");
            }
            var result=new MergeSort().DoSort(numbersList);
            Console.WriteLine();
            Console.WriteLine("After");
            Console.WriteLine();
            foreach (var number in result)
            {
                Console.Write(number + "\t");
            }

            Console.WriteLine();
        }
    }
}
