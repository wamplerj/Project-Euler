using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	public class Problem_010
	{

		public long CalculateSumOfAllPrimesUnderNumber(int number)
		{
			IEnumerable<long> primes = MathHelper.GetPrimeNumbersUnderNumber(2000000);

			long sum = 0;
			foreach (long prime in primes)
			{
				sum += prime;
			}

			return sum;
		}

	}
}
