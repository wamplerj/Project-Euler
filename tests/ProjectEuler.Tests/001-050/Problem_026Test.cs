using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_026Test
    {

        [Test]
        public void Calculate_The_Largest_Reoccuring_Cycle_Under_1000()
        {
            var problem = new Problem_026();
            var result = problem.CalculateLargestReoccuringCycle(1000);

            Assert.That(result, Is.EqualTo(982));
        }


    }
}
