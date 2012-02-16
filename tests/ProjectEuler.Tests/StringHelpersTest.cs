using NUnit.Framework;
using ProjectEuler.Helpers;

namespace ProjectEuler.Tests
{
    
	[TestFixture]
	public class StringHelpersTest
	{

		[Test]
		public void IsPalindromeTest()
		{
			string value = "9855589";

			bool actual = StringHelper.IsPalindrome(value);

			Assert.IsTrue(actual);

		}
	}
}
