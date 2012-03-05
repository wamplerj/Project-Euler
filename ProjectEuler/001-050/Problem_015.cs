using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_015
    {
        public long CalculateGridRoutes(int rows, int columns)
        {
            return BinomialCoefficient(rows*2, rows);
        }

        public static long BinomialCoefficient(int n, int k)
        {

            if (k > (n - k))
                k = n - k;

            long c = 1;

            for (int i = 0; i < k; i++)
            {
                c = c * (n - i);
                c = c / (i + 1);
            }

            return c;
        }
    }
}
