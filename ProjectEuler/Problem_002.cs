using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_002
	{
		public int SumOfEvenValueTermsInFibinacciSequence(int limit)
		{
			int sum = 2;
			int term1 = 1;
			int term2 = 2;
			int currentTerm = term1 + term2;

			while (currentTerm < limit)
			{
				if (currentTerm % 2 == 0)
					sum += currentTerm;

				term1 = term2;
				term2 = currentTerm;
				currentTerm = term1 + term2;

			}


			return sum;
		}


	}
}
