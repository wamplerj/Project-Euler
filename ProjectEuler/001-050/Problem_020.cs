using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace ProjectEuler
{
	public class Problem_020
	{

		public int CalulateSumOfFactorialDigits(int factorial)
		{

			BigInteger value = Helpers.MathHelper.Factorial(factorial);

			return Helpers.MathHelper.SumDigits(value);
		}




	}
}
