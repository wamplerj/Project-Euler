using System;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
   
	[TestFixture]
	public class Problem_004Test
	{

		[Test]
		public void CalculatePalindromeNumberTest()
		{
			var problem = new Problem_004();
			int actual = problem.CalculatePalindromeNumber(100, 999, 100, 999);

			Assert.AreEqual(906609, actual);
		}
	}
}
