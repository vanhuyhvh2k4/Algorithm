public class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        int currentMax = 1;
        int max = 1;

        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length - 1; j++)
            {
                if (s[j] == s[j + 1] || s[i] == s[j])
                {
                    i = j;
                    max = 1;
                } else
                {
                    max++;
                    if (max > currentMax)
                    {
                        currentMax = max;
                    }
                }
            }
        }

        return currentMax;
    }

    public static void Main(string[] args)
    {
        var result = LengthOfLongestSubstring("abcccabc");
        Console.WriteLine(result);
    }
}