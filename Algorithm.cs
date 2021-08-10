using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Algorihm<T> where T : IComparable
    {
        public T[] BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                T temp;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public void Display(T[] arr)
        {
            foreach (T sort in arr)
            {
                Console.Write(sort + " ");
            }
            Console.WriteLine();
        }
    }
}