using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_010Test
	{
		[Test]
		public void CalculateSumOfAllPrimesUnderNumberTest()
		{

			var problem = new Problem_010();
			long actual;

			actual = problem.CalculateSumOfAllPrimesUnderNumber(2000000);
			Assert.AreEqual(142913828922, actual);
		}
	}
}
