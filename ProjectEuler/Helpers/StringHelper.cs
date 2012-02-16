using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Helpers
{
	public static class StringHelper
	{

		public static bool IsPalindrome(string value)
		{

			var characters = value.ToLower().ToCharArray();

			for(int i = 0, j = characters.Length - 1; i < j; i++, j--)
			{
				char temp = characters[i];
				characters[j] = characters[i];
				characters[j] = temp;
			}
			string reversedValue = new string(characters);

			return value.Equals(reversedValue);

		}


	}
}
