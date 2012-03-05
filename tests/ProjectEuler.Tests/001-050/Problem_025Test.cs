using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    class Problem_025Test
    {

        [Test]
        public void Verify_That_The_First_Fibonacci_Term_With_One_Thousand_Digits_Is_4782()
        {
            var problem = new Problem_025();
            var result = problem.GetFirstFibonacciTermWithOneThousandDigits();

            Assert.That(result, Is.EqualTo(4782));
        }
    }
}
