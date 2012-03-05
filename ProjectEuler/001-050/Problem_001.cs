using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_001
	{


		public int SumOfNaturalNumbers(int limit)
		{

			int sum = 0;

			for (int i = 1; i < limit; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					sum += i;
			}

			return sum;

		}



	}
}
