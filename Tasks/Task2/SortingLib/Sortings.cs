using System;
namespace SortingLib 
{

    public enum Order
    {
        ASC,
        DESC
    }

    public static class Sortings
    {
        public static void BubleSort(ref string[] arr, Order order) 
        {
            for (int k = arr.Length; k > 0; --k)
        {
            for (int i = 0; i < k; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        }

        public static void SelectSort(ref string[] arr, Order order)
        {
            int max;
        for (int k = 0; k < arr.Length; k++)
        {
            // find index min 
            max = 0;
            for (int i = 1; i < arr.Length - k; i++)
            {
                if (arr[i] > arr[max])
                    max = i;
            }

            // swap
            int temp = arr[arr.Length - k - 1];
            arr[arr.Length - k - 1] = arr[max];
            arr[max] = temp;
        }
        }

        public static void InsertSort(ref string[] arr, Order order)
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(ref string[] arr, Order order)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(ref string[] arr, Order order)
        {
            throw new NotImplementedException();
        }
    }
}