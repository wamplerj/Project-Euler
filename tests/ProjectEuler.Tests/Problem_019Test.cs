using System;
using NUnit.Framework;

namespace ProjectEuler.Tests
{

	[TestFixture]
	public class Problem_019Test
	{

		[Test]
		public void Number_Of_First_Days_Of_the_Month_That_Were_Also_Sundays_In_The_Twentieth_Century()
		{
			var problem = new Problem_019();
			DateTime startDate = new DateTime(1901, 1, 1);
			DateTime endDate = new DateTime(2000, 12, 31);

			int actual;

			actual = problem.NumberOfDaysOfWeek(startDate, endDate, DayOfWeek.Sunday);
			Assert.AreEqual(171, actual);

		}
	}
}
