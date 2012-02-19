using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	public class Problem_011
	{

		private List<int> matches = new List<int>();

		public int CalculateSumOfConsecutiveNumbers(string source, int consecutive)
		{

			var digits = source.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(col => col.Split(' ').Where(token => token.IsInteger()).Select(token => int.Parse(token)).ToList()).ToList();


			for (int i = 0; i < digits.Count; i++)
			{
				for (int j = 0; j < digits.Count; j++)
				{

					//Horizontal matches
					if (i + consecutive < digits.Count)
					{
						int value = CalculateProductFromValues(digits[i].GetRange(i, consecutive));
						matches.Add(value);
					}

					//Vertical matches
					if (j + consecutive < digits.Count)
					{
						List<int> values = new List<int>();
						for (int count = 0; count < consecutive; count++)
						{
							values.Add(digits[i][j + count]);
						}

						int value = CalculateProductFromValues(values);
						matches.Add(value);

					}

					//Upper Forward Diagonal Matches "/"
					if (j > consecutive - 1 && i + consecutive < digits.Count)
					{
						List<int> values = new List<int>();
						for (int count = 0; count < consecutive; count++)
						{
							values.Add(digits[i + count][j - count]);
						}

						int value = CalculateProductFromValues(values);
						matches.Add(value);

					}

					//Lower Forward Diagonal Matches "\"
					if (j + consecutive < digits.Count && i + consecutive < digits.Count)
					{
						List<int> values = new List<int>();
						for (int count = 0; count < consecutive; count++)
						{
							values.Add(digits[i + count][j + count]);
						}

						int value = CalculateProductFromValues(values);
						matches.Add(value);

					}

				}
			}

			return matches.Max();
		}
  
		private int CalculateProductFromValues(IEnumerable<int> values)
		{
			return (int)values.Aggregate(1, (x, y) => x * y);
		}
	}

}
