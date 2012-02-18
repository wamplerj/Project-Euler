using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
	public class Problem_011
	{

		var matches = new List<int>();

		public int CalculateSumOfConsecutiveNumbers(string source, int consecutive)
		{

			// create a list of lists of ints representing the cells
			var digits = source.
				// split string into rows
				Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
				.Select(
				line =>
					// split row into columns
				line.Split(' ')
					// ignore any whitespace
					.Where(token => token.IsInteger())
					// convert string to number
					.Select(token => int.Parse(token))
					.ToList()
				)
				.ToList();

			//TODO Get Forward Horizontal


			//TODO Get Forward Vertical
			//TODO Get Forward Diagonal
			//TODO Get Reverse Diagonal

			return 0;
		}

		private List<int> GetHorizontalMatches(List<int[]> digits, int consecutive)
		{

			for (int i = 0; i < digits[0].Length - consecutive - 1; i++)
			{



			}


		}

	}

}
