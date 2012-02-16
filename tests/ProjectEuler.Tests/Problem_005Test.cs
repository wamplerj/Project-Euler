using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_005Test
	{
		[Test]
		public void Calculate_Smallest_Integer_Evenly_Divisible_By_1_Thru_10()
		{

			var problem = new Problem_005();
			var value = problem.CalculateSmallestIntegerRange(10);

			Assert.That(value, Is.EqualTo(2520));


		}

		[Test]
		public void Calculate_Smallest_Integer_Evenly_Divisible_By_1_Thru_20()
		{

			var problem = new Problem_005();
			var value = problem.CalculateSmallestIntegerRange(20);

			Assert.That(value, Is.EqualTo(232792560));

		}

	}
}
