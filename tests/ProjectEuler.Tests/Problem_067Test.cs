using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_067Test
    {

        [Test]
        public void Find_Largest_Sum_From_Triangle_With_100_Rows()
        {
            var problem = new Problem_018();
            problem.LoadTriangle("067.txt");
            var result = problem.FindLargestSum();

            Assert.That(result, Is.EqualTo(7273));

        }

    }
}
