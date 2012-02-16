using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_009Test
	{
		[Test]
		public void CalculateProductOfPythagoreanTripletTest()
		{

			var problem = new Problem_009(); 
			long actual;

			actual = problem.CalculateProductOfPythagoreanTriplet(1000);
			Assert.AreEqual(31875000, actual);

		}
	}
}
