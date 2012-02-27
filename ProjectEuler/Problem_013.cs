using System.Numerics;
using ProjectEuler.Helpers;

namespace ProjectEuler
{
    public class Problem_013
    {
        public string GetFirstXDigitsFromSumOfArrayOfNumbers(BigInteger[] numbers)
        {
            BigInteger sum = BigInteger.Zero;

            foreach (var number in numbers)
            {
                sum += number;
            }

            string sumString = sum.ToString();

            return sumString.Substring(0, 10);
        }
    }
}