using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class DivisorSumCalculator
    {
        private Dictionary<int, int> _divisorSums = new Dictionary<int, int>();

        public int GetSumOfDivisors(int n)
        {

            if (_divisorSums.ContainsKey(n))
                return _divisorSums[n];

            var divisors = new List<int>();

            int divisorToTest = 2, result = n;

            while (divisorToTest < n)
            {

                if (n % divisorToTest == 0)
                {
                    result = n / divisorToTest;
                    divisors.Add(result);
                    divisors.Add(divisorToTest);
                }

                divisorToTest++;
            }

            var distinct = divisors.Distinct().ToList();
            distinct.Sort();
            var sum = distinct.Sum();

            _divisorSums.Add(n, sum + 1);

            return sum + 1;

            //return divisors.Distinct().Sum();
        }
    }
}
