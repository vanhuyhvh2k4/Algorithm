class Program
{
    static void Main()
    {

    }

    static int Search(int[] arr, int target)
    {
        int leftIndex = 0;
        int rightIndex = arr.Length - 1;

        while(leftIndex < rightIndex)
        {
            int mid = (leftIndex + rightIndex) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }else if (target < arr[mid])
            {
                rightIndex = mid - 1;
            } else
            {
                leftIndex = mid + 1;
            }
        }

        return -1;
    }
}