using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Algorithm<T> where T : IComparable
    {
        public void InsertionSort(T[] arr)
        {
            T max;
            for (int i = 1; i < arr.Length; i++)
            {
                max = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j].CompareTo(max) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = max;
            }
        }
        public void Display(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
