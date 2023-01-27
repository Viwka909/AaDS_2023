namespace Lesson3;

public static class Sorting
{
    public static void Bubble(ref int[] arr)
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

    public static void SelectSort(ref int[] arr)
    {
        int max;
        for (int k = 0; k < arr.Length; k++)
        {
            max = 0;
            for (int i = 1; i < arr.Length - k; i++)
            {
                if (arr[i] > arr[max])
                    max = i;
            }
            
            int temp = arr[arr.Length - k - 1];
            arr[arr.Length - k - 1] = arr[max];
            arr[max] = temp;
        }
    }

    public static void InsertSort(ref int[] arr)
    {
        
    }

}