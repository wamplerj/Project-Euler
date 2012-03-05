using NUnit.Framework;

namespace ProjectEuler.Tests
{
    
	[TestFixture]
	public class Problem_016Test
	{

		[Test]
		public void CalculateSumOfExponentNumberTest()
		{
			var problem = new Problem_016(); // TODO: Initialize to an appropriate value
			int actual;
			
			actual = problem.CalculateSumOfExponentNumber(2, 1000);
			Assert.AreEqual(1366, actual);

		}
	}
}
