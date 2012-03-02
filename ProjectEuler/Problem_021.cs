using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_021
    {

        private Dictionary<int, int> _divisorSums = new Dictionary<int, int>();

        public bool IsAmicablePair(int i, int j)
        {

            var iSum = GetSumOfDivisors(i);
            var jSum = GetSumOfDivisors(j);

            return i == jSum && j == iSum;
        }

        private int GetSumOfDivisors(int n)
        {

            if (_divisorSums.ContainsKey(n))
                return _divisorSums[n];

            var divisors = new List<int>();

            int divisorToTest = 2, result = n;

            while (divisorToTest < n)
            {

                if(n % divisorToTest == 0)
                {
                    result = n/divisorToTest;
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

        public int GetSumOfAmicablePairsUnder(int n)
        {
            var amicableNumbers = new Dictionary<int, int>();

            for(int i = 1; i < n; i++)
            {

                if(amicableNumbers.ContainsKey(i))
                    continue;

                int sum1 = GetSumOfDivisors(i);

                if (sum1 <= 1 || i == sum1)
                    continue;

                if(IsAmicablePair(i, sum1))
                {
                    if(!amicableNumbers.ContainsKey(i))
                        amicableNumbers.Add(i, sum1);
                }
            }

            return amicableNumbers.Sum(i => i.Value);
        }
    }
}
