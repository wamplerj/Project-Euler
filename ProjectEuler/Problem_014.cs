using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	public class Problem_014
	{

		private Dictionary<long, int> chains = new Dictionary<long, int>();

		public long GetLargestChain(long start)
		{
			long largestNumber = 0;
			int largestCount = 0;
			for (long i = 2; i < start; i++)
			{
				int count = BuildChain(i);

				if(!chains.ContainsKey(i))
					chains.Add(i, count);

				if (count > largestCount)
				{
					largestCount = count;
					largestNumber = i;
				}
			}

			return largestNumber;
		}

		private int BuildChain(long start)
		{

			int count = 0;
			while (start != 1)
			{
				if (start % 2 == 0)
					start /= 2;
				else
					start = (3 * start) + 1;

				if (chains.ContainsKey(start))
				{
					count = count + chains[start];
					break;
				}

				count++;
			}

			return count;
		}
	}
}
