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
            bool swapRequired;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapRequired = false;
                if (order == Order.DESC)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if ((arr[j].CompareTo(arr[j + 1])) > 0)
                        {
                            Swap(arr[j], arr[j + 1], arr, j, j + 1);
                            swapRequired = true;
                        }
                    }
                }
                if (order == Order.ASC)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if ((arr[j].CompareTo(arr[j + 1])) < 0)
                        {
                            Swap(arr[j], arr[j + 1], arr, j, j + 1);
                            swapRequired = true;
                        }
                    }
                }
                if (swapRequired == false)
                    break;
            }
        }

        public static void SelectSort(ref string[] arr, Order order)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var smallestVal = i;
                if (order == Order.ASC)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if ((arr[j].CompareTo(arr[smallestVal])) > 0)
                        {
                            smallestVal = j;
                        }
                    }
                    Swap(arr[i], arr[smallestVal], arr, i, smallestVal);
                }
                if (order == Order.DESC)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if ((arr[j].CompareTo(arr[smallestVal])) < 0)
                        {
                            smallestVal = j;
                        }
                    }
                    Swap(arr[i], arr[smallestVal], arr, i, smallestVal);
                }

            }
        }

        public static void InsertSort(ref string[] arr, Order order)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var flag = 0;
                if (order == Order.ASC)
                {
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if ((key.CompareTo(arr[j])) > 0)
                        {
                            arr[j + 1] = arr[j];
                            j--;
                            arr[j + 1] = key;
                        }
                        else flag = 1;
                    }
                }
                if (order == Order.DESC)
                {
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if ((key.CompareTo(arr[j])) < 0)
                        {
                            arr[j + 1] = arr[j];
                            j--;
                            arr[j + 1] = key;
                        }
                        else flag = 1;
                    }
                }

            }
        }

        public static void MergeSort(ref string[] arr, Order order)
        {
            int left = 0;
            int right = arr.Length - 1;
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(arr, left, middle, order);
                MergeSort(arr, middle + 1, right, order);
                Mergearr(arr, left, middle, right, order);
            }
        }
        public static void MergeSort(string[] arr, int left, int right, Order order)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(arr, left, middle, order);
                MergeSort(arr, middle + 1, right, order);
                Mergearr(arr, left, middle, right, order);
            }
        }

        public static void QuickSort(ref string[] arr, Order order)
        {
            QuickSort(arr, 0, arr.Length - 1, order);
        }
        public static void Mergearr(string[] arr, int left, int middle, int right, Order order)
        {
            var leftarrLength = middle - left + 1;
            var rightarrLength = right - middle;
            var leftTemparr = new string[leftarrLength];
            var rightTemparr = new string[rightarrLength];
            int i, j;
            for (i = 0; i < leftarrLength; ++i)
                leftTemparr[i] = arr[left + i];
            for (j = 0; j < rightarrLength; ++j)
                rightTemparr[j] = arr[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            if (order == Order.ASC)
            {
                while (i < leftarrLength && j < rightarrLength)
                {
                    if ((leftTemparr[i].CompareTo(rightTemparr[j])) >= 0)
                    {
                        arr[k++] = leftTemparr[i++];
                    }
                    else
                    {
                        arr[k++] = rightTemparr[j++];
                    }
                }
            }
            if (order == Order.DESC)
            {
                while (i < leftarrLength && j < rightarrLength)
                {
                    if ((leftTemparr[i].CompareTo(rightTemparr[j])) <= 0)
                    {
                        arr[k++] = leftTemparr[i++];
                    }
                    else
                    {
                        arr[k++] = rightTemparr[j++];
                    }
                }
            }

            while (i < leftarrLength)
            {
                arr[k++] = leftTemparr[i++];
            }
            while (j < rightarrLength)
            {
                arr[k++] = rightTemparr[j++];
            }
        }
        public static void QuickSort(string[] arr, int leftIndex, int rightIndex, Order order)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = arr[leftIndex];
            if (order == Order.DESC)
            {
                while (i <= j)
                {
                    while (arr[i].CompareTo(pivot) < 0)
                    {
                        i++;
                    }

                    while (arr[j].CompareTo(pivot) > 0)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        Swap(arr[i], arr[j], arr, i, j);
                        i++;
                        j--;
                    }
                }
            }
            if (order == Order.ASC)
            {
                 while (i <= j)
                {
                    while (arr[i].CompareTo(pivot) > 0)
                    {
                        i++;
                    }

                    while (arr[j].CompareTo(pivot) < 0)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        Swap(arr[i], arr[j], arr, i, j);
                        i++;
                        j--;
                    }
                }
            }


            if (leftIndex < j)
                QuickSort(arr, leftIndex, j, order);
            if (i < rightIndex)
                QuickSort(arr, i, rightIndex, order);
        }
        public static void Swap(string str1, string str2, string[] arr, int index1, int index2)
        {
            string temp = str1;
            arr[index1] = str2;
            arr[index2] = temp;
        }

    }
}