using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Algorithm<T> where T : IComparable
    {
        T[] array;
        public Algorithm(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
       
        public int BinarySearch(T[] array, T element)
        {
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int key = element.CompareTo(array[mid]);
                if (key == 0)
                    return mid;
                if (key > 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}