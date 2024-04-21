public class Program
{
    public static string LongestCommonPrefix(string[] strs)
    {

        string text = "";
        string currentLetter = "";

        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = 0; j < strs[i].Length; j++)
            {
                if (currentLetter == strs)
            }
        }

        return text;
    }

    public static void Main(string[] args)
    {
        string[] arr = {"hello", "help", "heart" };
        var result = LongestCommonPrefix(arr);
        Console.WriteLine(result);
    }
}