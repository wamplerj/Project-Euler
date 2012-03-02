using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_017Test
    {

        [Test]
        public void When_Calculating_The_Number_Of_Letters_In_All_The_Words_Under_5()
        {
            var problem = new Problem_017();
            var result = problem.CalculateLettersInWordsUnder(5);

            Assert.That(result, Is.EqualTo(19));
        }

        [Test]
        public void When_Calculating_The_Number_Of_Letters_In_All_The_Words_Under_20()
        {
            var problem = new Problem_017();
            var result = problem.CalculateLettersInWordsUnder(20);

            Assert.That(result, Is.EqualTo(112));
        }


        [Test]
        public void When_Calculating_The_Number_Of_Letters_In_All_The_Words_Under_1000()
        {
            var problem = new Problem_017();
            var result = problem.CalculateLettersInWordsUnder(1000);

            Assert.That(result, Is.EqualTo(21124));
        }

        [Test]
        public void When_Calculating_Number_Of_Letters_In_342_The_Result_Is_23()
        {

            var problem = new Problem_017();
            var result = problem.GetWordLength(342);

            Assert.That(result, Is.EqualTo(23));

        }

        [Test]
        public void When_Calculating_Number_Of_Letters_In_115_The_Result_Is_20()
        {

            var problem = new Problem_017();
            var result = problem.GetWordLength(115);

            Assert.That(result, Is.EqualTo(20));

        }

        [Test]
        public void When_Calculating_Number_Of_Letters_In_300_The_Result_Is_12()
        {

            var problem = new Problem_017();
            var result = problem.GetWordLength(300);

            Assert.That(result, Is.EqualTo(12));

        }

        [Test]
        public void When_Calculating_Number_Of_Letters_In_20_The_Result_Is_6()
        {

            var problem = new Problem_017();
            var result = problem.GetWordLength(20);

            Assert.That(result, Is.EqualTo(6));

        }

        [Test]
        public void When_Calculating_Number_Of_Letters_In_313_The_Result_Is_23()
        {

            var problem = new Problem_017();
            var result = problem.GetWordLength(313);

            Assert.That(result, Is.EqualTo(23));

        }


    }
}
