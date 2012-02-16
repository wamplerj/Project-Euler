using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Helpers
{
	public static class MathHelper
	{

		public static BigInteger Factorial(int factorial)
		{
			if (factorial == 1)
				return 1;

			var value = factorial * Factorial(factorial - 1);

			return value;

		}


		public static int SumDigits(BigInteger value)
		{
			int sum = 0;
			string strValue = value.ToString();
			char[] digits = strValue.ToCharArray();

			foreach (char digit in digits)
			{
				sum += Int32.Parse(digit.ToString());
			}

			return sum;
		}

		public static bool IsPrime(long number)
		{
			if ((number & 1) == 0)
				return number == 2;

			for (int i = 3; (i * i) <= number; i += 2)
			{
				if ((number % i) == 0)
				{
					return false;
				}
			}
			return number != 1;

		}


		public static IEnumerable<long> GetPrimeNumbersUnderNumber(long number)
		{
			List<long> primes = new List<long>();
			for (int i = 2; i < number; i++)
			{
				bool divisible = false;

				foreach (int num in primes)
				{
					if (i % num == 0)
						divisible = true;

					if (num > Math.Sqrt(i))
						break;
				}

				if (divisible == false)
				{
					primes.Add(i);
					//Console.WriteLine("{0}", i);
				}
			}
			return primes;
		}

		public static long LeastCommonMultiple(long value1, long value2)
		{

			return (value1 * value2) / GreatestCommonDivisor(value1, value2);
		}

		private static long GreatestCommonDivisor(long value1, long value2)
		{
			while (value1 != value2)
			{

				if (value1 > value2)
					value1 = value1 - value2;


				if (value2 > value1)
					value2 = value2 - value1;

			}

			return value1;
		}
	}
}
