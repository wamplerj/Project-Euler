using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    class Problem_024Test
    {

        [Test]
        public void Calculate_The_One_Millionth_Permutation_Of_0_Thru_9()
        {

            var problem = new Problem_024();
            var result = problem.CalculateNthPermutation(1000000);

            Assert.That(result, Is.EqualTo("2783915460"));

        }
    }
}
