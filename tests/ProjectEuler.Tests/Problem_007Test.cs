using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_007Test
	{
		[Test]
		public void The_5th_Prime_Number_Is_11()
		{

			var problem = new Problem_007();
			var result = problem.FindNthPrime(5);

			Assert.That(result, Is.EqualTo(11));

		}


		[Test]
		public void The_10001st_Prime_Is_104743()
		{
			var problem = new Problem_007();
			var result = problem.FindNthPrime(10001);

			Assert.That(result, Is.EqualTo(104743));
		}
	}
}
