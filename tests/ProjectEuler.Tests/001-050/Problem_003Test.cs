using NUnit.Framework;

namespace ProjectEuler.Tests
{
   
	[TestFixture]
	public class Problem_003Test
	{


		[Test]
		public void Calculate_The_Largest_Prime_Factor_For_13195_Equals_29()
		{
			var problem = new Problem_003();
	
			long result = problem.CalculateLargestPrimeFactor(13195);
			Assert.AreEqual(29, result);
		}

		[Test]
		public void Calculate_The_Largest_Prime_Factor_For_600851475143_Equals_6857()
		{
			var problem = new Problem_003();

			long result = problem.CalculateLargestPrimeFactor(600851475143);
			Assert.AreEqual(6857, result);
		}
	}
}
