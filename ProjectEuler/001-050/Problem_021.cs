using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_021
    {
        private DivisorSumCalculator divisorSumCalculator = new DivisorSumCalculator();
      
        public bool IsAmicablePair(int i, int j)
        {

            var iSum = divisorSumCalculator.GetSumOfDivisors(i);
            var jSum = divisorSumCalculator.GetSumOfDivisors(j);

            return i == jSum && j == iSum;
        }

        public int GetSumOfAmicablePairsUnder(int n)
        {
            var amicableNumbers = new Dictionary<int, int>();

            for(int i = 1; i < n; i++)
            {

                if(amicableNumbers.ContainsKey(i))
                    continue;

                int sum1 = divisorSumCalculator.GetSumOfDivisors(i);

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
