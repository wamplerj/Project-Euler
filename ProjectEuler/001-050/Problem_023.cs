using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_023
    {
        private DivisorSumCalculator divisorSumCalculator = new DivisorSumCalculator();
        private List<int> abundentNumbers = new List<int>();
        private readonly int limit = 28123 + 1;


        public bool IsAbundent(int n)
        {
            var sum = divisorSumCalculator.GetSumOfDivisors(n);
            return  sum > n;
        }

        public int CalculateAbundentNumberSum()
        {

            for (int i = 2; i < limit; i++ )
            {

                int currentSum = divisorSumCalculator.GetSumOfDivisors(i);

                if (currentSum > i)
                    abundentNumbers.Add(i);
            }

            bool[] abn = new bool[limit];

            for (int i = 0; i < abundentNumbers.Count; i++ )
            {
                for (int j = i; j < abundentNumbers.Count; j++)
                {
                    int currentSum = abundentNumbers[i] + abundentNumbers[j];

                    if (currentSum < limit)
                        abn[currentSum] = true;
                    else
                        break;
                }
            }

            int answer = 0;
            for (int i = 0; i < limit; i++)
            {
                if (!abn[i]) answer += i;
            }

            return answer;

        }
    }
}
