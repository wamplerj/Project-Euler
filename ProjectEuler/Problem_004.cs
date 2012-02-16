using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_004
	{

		public int CalculatePalindromeNumber(int startRange1, int endRange1, int startRange2, int endRange2)
		{

			int largestPalindrome = 0;

			for (int i = startRange1; i <= endRange1; i++)
			{
				for (int j = startRange2; j <= endRange2; j++)
				{

					int value = i * j;
					if (Helpers.StringHelper.IsPalindrome(value.ToString()) && value > largestPalindrome)
						largestPalindrome = value;
				}
			}

			return largestPalindrome;

		}
	}
}
