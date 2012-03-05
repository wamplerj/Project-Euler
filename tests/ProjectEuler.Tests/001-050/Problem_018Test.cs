using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_018Test
    {


        [Test]
        public void Verify_That_The_Largest_Sum_Of_The_Sample_Triangle_Is_23()
        {

            var problem = new Problem_018();
            problem.LoadTriangle("018-sample.txt");
            var result = problem.FindLargestSum();

            Assert.That(result, Is.EqualTo(23));

        }


        [Test]
        public void Find_The_Largest_Sum_Navigating_A_Triangle()
        {

            var problem = new Problem_018();
            problem.LoadTriangle("018.txt");
            var result = problem.FindLargestSum();

            Assert.That(result, Is.EqualTo(1074));
        }


    }
}