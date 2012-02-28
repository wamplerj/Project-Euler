using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_015Tests
    {

        [Test]
        public void When_Calculating_Routes_In_A_2_By_2_Grid_There_Are_6()
        {
            var problem = new Problem_015();
            var result = problem.CalculateGridRoutes(2, 2);


            Assert.That(result, Is.EqualTo(6));


        }

        [Test]
        public void When_Calculating_Routes_In_A_20_By_20_Grid_There_Are_137846528820()
        {
            var problem = new Problem_015();
            var result = problem.CalculateGridRoutes(20, 20);


            Assert.That(result, Is.EqualTo(137846528820));


        }

    }
}
