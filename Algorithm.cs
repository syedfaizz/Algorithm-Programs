using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
	class Algorithm<T> where T : IComparable
	{
		public void MergeSort(T[] arr, int start, int end)
		{
			if (arr.Length == 1)
			{
				Console.WriteLine("Element is already sorted \n" + arr);
			}
			if (start < end)
			{
				int mid = (start + end) / 2;
				Merge_Sort(arr, start, mid);
				Merge_Sort(arr, mid + 1, end);
				Merge(arr, start, mid, end);
			}
		}
		public void Merge(T[] arr, int start, int mid, int end)
		{
			T[] temp = new T[end - start + 1];
			int i = start, j = mid + 1, k = 0;
			while (i <= mid && j <= end)
			{
				if (arr[i].CompareTo(arr[j]) <= 0)
				{
					temp[k] = arr[i];
					k += 1; i += 1;
				}
				else
				{
					temp[k] = arr[j];
					k += 1; j += 1;
				}
			}
			while (i <= mid)
			{
				temp[k] = arr[i];
				k += 1; i += 1;
			}
			while (j <= end)
			{
				temp[k] = arr[j];
				k += 1; j += 1;
			}
			for (i = start; i <= end; i += 1)
			{
				arr[i] = temp[i - start];
			}
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