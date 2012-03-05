using System;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	public class Problem_005
	{

		public long CalculateSmallestIntegerRange(int topOfRange)
		{

			var primesUnderTopOfRange = MathHelper.GetPrimeNumbersUnderNumber(topOfRange);

			long total = 1;
			foreach (var prime in primesUnderTopOfRange)
			{

				if (prime < topOfRange)
				{
					long power = (long)Math.Floor(Math.Log(topOfRange) / Math.Log(prime));
					total *= (long)Math.Pow(prime,power);
				}
				else
				{
					total *= prime;
				}
			}

			return total;

		}

	}
}
