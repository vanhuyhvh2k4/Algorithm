using System;
namespace palindrome_number
{
	public class Program
	{
		public static bool IsPalindrome(int x)
		{
            if (x < 0)
            {
                return false;
            }

			string strX = x.ToString();

			int leftPoint = 0;
			int rightPoint = strX.Length - 1;

			while (leftPoint < rightPoint)
			{
				if (strX[leftPoint] != strX[rightPoint])
				{
					return false;
				}

				leftPoint++;
				rightPoint--;
			}

            return true;
        }


        public static void Main(string[] args)
		{
			var result = IsPalindrome(-1221);

			Console.WriteLine(result);
		}
	}
}

