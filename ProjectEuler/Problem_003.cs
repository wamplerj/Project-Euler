using System;
using System.Linq;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	public class Problem_003
	{

		public long CalculateLargestPrimeFactor(long number)
		{
			unchecked
			{
				while (number > 3 && 0 == (number & 1)) number >>= 1;

				int k = 3;
				long k2 = 9;
				long delta = 16;
				while (k2 <= number)
				{
					if (number % k == 0)
					{
						number /= k;
					}
					else
					{
						k += 2;
						if (k2 + delta < delta) return number;
						k2 += delta;
						delta += 8;
					}
				}
			}

			return number;

		}

		
	}
}
