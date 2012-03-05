using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_012Test
	{

		[Test]
		public void The_First_Triangle_Number_With_5_Factors_Is_28()
		{
			var problem = new Problem_012();
			var result = problem.CalculateFirstTriangleNumberWithNDivisors(5);

			Assert.That(result, Is.EqualTo(28));

		}

		[Test]
        public void The_First_Triangle_Number_With_5_Factors_Is_76576500()
		{

			var problem = new Problem_012();
			var result = problem.CalculateFirstTriangleNumberWithNDivisors(500);

            Assert.That(result, Is.EqualTo(76576500));

		}
	}
}
