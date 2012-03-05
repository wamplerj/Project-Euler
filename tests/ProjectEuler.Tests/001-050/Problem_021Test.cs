using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_021Test
    {

        [Test]
        public void Verify_That_284_Is_Amicable_Pair_With_220()
        {

            var problem = new Problem_021();
            var result = problem.IsAmicablePair(220, 284);

            Assert.That(result, Is.True);
        }




        [Test]
        public void Get_The_Sum_Of_All_Amicable_Pairs_Under_10000()
        {
            var problem = new Problem_021();
            var result = problem.GetSumOfAmicablePairsUnder(10000);

            Assert.That(result, Is.EqualTo(31626));

        }


    }
}
