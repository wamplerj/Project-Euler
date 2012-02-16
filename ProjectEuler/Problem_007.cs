using System;
using System.Linq;
using ProjectEuler.Helpers;


namespace ProjectEuler
{
	public class Problem_007
	{
		public long FindNthPrime(int n)
		{
			int index = 1;
			int primesFound = 0;
			long nthPrime = 0;

			while (primesFound < n)
			{
				if (MathHelper.IsPrime(index))
					primesFound++;

				if (primesFound == n)
					nthPrime = index;

				index++;

			}

			return nthPrime;
		}
	}
}
