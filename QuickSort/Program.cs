class Program
{
    static void Main()
    {
        var arr = new int[] { -1, 0, 2, -3, -2, -2, 5 };

        Quicksort(arr, 0, arr.Length - 1);

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void Quicksort(int[] arr, int leftIndex, int rightIndex)
    {
        if (rightIndex > leftIndex)
        {
            int p = Partition(arr, leftIndex, rightIndex);
            Quicksort(arr, leftIndex, p - 1);
            Quicksort(arr, p + 1, rightIndex);
        }
    }

    static int Partition(int[] arr, int leftIndex, int rightIndex)
    {
        int pivot = arr[rightIndex];

        int i = (leftIndex - 1);

        for (int j = leftIndex; j < rightIndex; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, rightIndex);
        return (i + 1);
    }

    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}