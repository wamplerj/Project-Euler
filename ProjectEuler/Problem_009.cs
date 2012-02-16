using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_009
	{

		public long CalculateProductOfPythagoreanTriplet(int number)
		{
			for (int a = 1; a <= number; a++)
			{
				for (int b = 1; b <= number; b++)
				{
					for (int c = 1; c <= number; c++)
					{
						if (a + b + c == number && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)))
						{
							return a * b * c;
							//Console.WriteLine("a={0}, b={1}, c={2} ", a, b, c);
							//Console.WriteLine("Product: {0}", a * b * c);
						}
					}
				}
			}

			return 0;
		}
	}
}
