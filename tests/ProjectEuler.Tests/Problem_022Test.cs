using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    class Problem_022Test
    {
        [Test]
        public void Calculate_The_Sum_Of_All_Names_In_List()
        {
            var problem = new Problem_022();
            var result = problem.CalculateAllNameScores();

            Assert.That(result, Is.EqualTo(871198282));

        }

        [Test]
        public void Verify_NameScore_Of_COLIN_Is_53()
        {
            var problem = new Problem_022();
            var result = problem.GetNameScore("COLIN");

            Assert.That(result, Is.EqualTo(53));

        }

    }
}
