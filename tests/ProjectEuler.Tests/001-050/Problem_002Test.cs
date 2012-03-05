using System;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_002Test
	{
		[Test]
		public void Sum_Of_All_Even_Numbers_In_Fibinnaci_Sequence_Under_4_Million_Equals_4613732()
		{
			var problem = new Problem_002();

			int result = problem.SumOfEvenValueTermsInFibinacciSequence(4000000);

			Assert.AreEqual(4613732, result);



		}
	}
}
