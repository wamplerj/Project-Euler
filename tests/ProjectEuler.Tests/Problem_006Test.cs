using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_006Test
	{

		[Test]
		public void Calculate_Difference_Between_Sum_Of_Squares_And_Sqaure_of_Sums_For_10_Equals_2640()
		{

			var problem = new Problem_006();
			var result = problem.CalculateDifferenceBetweenSumOfSquaresAndSquareOfSums(10);

			Assert.That(result, Is.EqualTo(2640));

		}

		[Test]
		public void Calculate_Difference_Between_Sum_Of_Squares_And_Sqaure_of_Sums_For_100_Equals_25164150()
		{

			var problem = new Problem_006();
			var result = problem.CalculateDifferenceBetweenSumOfSquaresAndSquareOfSums(100);

			Assert.That(result, Is.EqualTo(25164150));

		}
	}
}
