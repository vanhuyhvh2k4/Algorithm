public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] index = new int[2];
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    index[0] = i;
                    index[1] = j;
                }
            }
        }
        return index;
    }

    static void Main(string[] args)
    {
        int[] array = { 3, 3, 4 };

        var result = TwoSum(array, 6);
    }
}