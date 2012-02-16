using NUnit.Framework;

namespace ProjectEuler.Tests
{
    
	[TestFixture]
	public class Problem_020Test
	{

		[Test]
		public void Calulate_The_Sum_Of_The_Digits_In_100_Factorial()
		{
			var problem = new Problem_020();
			int actual;

			actual = problem.CalulateSumOfFactorialDigits(100);
			Assert.AreEqual(648, actual);


		}
	}
}
