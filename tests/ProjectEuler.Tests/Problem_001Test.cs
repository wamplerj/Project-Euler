using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_001Test
	{

		[Test]
		public void Sum_Of_All_Natural_Numbers_That_Are_Multiples_Of_3_or_5_Under_10_Equals_23()
		{

			var problem = new Problem_001();

			int result = problem.SumOfNaturalNumbers(10);

			Assert.AreEqual(23, result);
		
		}

		[Test]
		public void Sum_Of_All_Natural_Numbers_That_Are_Multiples_Of_3_or_5_Under_1000_Equals_233168()
		{

			var problem = new Problem_001();

			int result = problem.SumOfNaturalNumbers(1000);

			Assert.AreEqual(233168, result);

		}


	}
}
