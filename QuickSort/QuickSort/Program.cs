using System;

namespace QuickSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;

            QuickSort.quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            QuickSort.printArray(arr, n);
        }
    }
}
