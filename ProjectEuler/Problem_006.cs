using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_006
	{

		public long CalculateDifferenceBetweenSumOfSquaresAndSquareOfSums(int topOfRange)
		{

			long sumOfSquares = 0;
			long squareOfSums = 0;

			for (int i = 1; i <= topOfRange; i++)
			{

				sumOfSquares += (long)Math.Pow(i, 2);
				squareOfSums += i;

			}

			squareOfSums = (long)Math.Pow(squareOfSums, 2);

			return squareOfSums - sumOfSquares;
		}


	}
}
