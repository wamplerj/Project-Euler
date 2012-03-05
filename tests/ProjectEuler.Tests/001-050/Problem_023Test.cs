using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_023Test
    {

        [Test]
        public void Verify_That_12_Is_An_Abundent_Number()
        {
            var problem = new Problem_023();
            var result = problem.IsAbundent(12);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Verify_That_The_Sum_Of_All_Abundent_Number_That_Are_Not_The_Sum_Of_Abundent_Numbers_is_4179871()
        {
            var problem = new Problem_023();
            var result = problem.CalculateAbundentNumberSum();

            Assert.That(result, Is.EqualTo(4179871));
        }

    }
}
