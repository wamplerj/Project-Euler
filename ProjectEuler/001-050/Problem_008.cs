using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	class Problem_008
	{
		public long FindLargestProductInString(string source, int range)
		{
			long largestProduct = 0;

			int index = 0;
			while(index <= source.Length - range)
			{
				var product = MathHelper.MultiplyDigits(source.Substring(index, range));

				if (product > largestProduct)
					largestProduct = product;

				index++;
			}


			return largestProduct;
		}
	}
}
