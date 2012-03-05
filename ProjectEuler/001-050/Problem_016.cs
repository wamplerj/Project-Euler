using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
	public class Problem_016
	{

		public int CalculateSumOfExponentNumber(int baseNumber, int exponent)
		{

			BigInteger number = BigInteger.Pow(baseNumber, exponent);

			return Helpers.MathHelper.SumDigits(number);

		}

	}
}
