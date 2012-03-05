using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler
{
    class Problem_025
    {
        public int GetFirstFibonacciTermWithOneThousandDigits()
        {
            BigInteger term1 = 1;
            BigInteger term2 = 2;
            BigInteger currentTerm = term1 + term2;
            int termCount = 3;

			while (currentTerm.ToString().Length < 1000)
			{
			    termCount++;
				term1 = term2;
				term2 = currentTerm;
				currentTerm = term1 + term2;

			}

			return termCount + 1;
		}
    }
}
