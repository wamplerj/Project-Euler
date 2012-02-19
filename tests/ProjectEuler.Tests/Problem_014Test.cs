using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
	[TestFixture]
	public class Problem_014Test
	{

		[Test]
		public void Find_Number_With_The_Largest_Chain_Of_Terms()
		{

			var problem = new Problem_014();
			var result = problem.GetLargestChain(1000000);

			Assert.That(result, Is.EqualTo(837799));

		}
	}
}
