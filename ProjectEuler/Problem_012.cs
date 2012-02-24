namespace ProjectEuler
{
    public class Problem_012
    {
        public long CalculateFirstTriangleNumberWithNDivisors(int numberOfDivisors)
        {
            long currentTriangleValue = 1;
            long currentTriangleCount = 1;

            long currentNumberOfDivisors = 0;

            while (currentNumberOfDivisors < numberOfDivisors)
            {
                currentTriangleCount++;
                currentTriangleValue = currentTriangleValue + currentTriangleCount;

                currentNumberOfDivisors = GetDivisorCount(currentTriangleValue);
            }

            return currentTriangleValue;
        }

        private long GetDivisorCount(long num)
        {
            int numTotal = 0;

            if (num > 1)
            {
                if (num%2 == 0)
                {
                    for (long i = 1; i*i <= num; i++)
                        if (num%i == 0)
                            numTotal += 2;
                }
                else
                {
                    // halves the time for odd numbers
                    for (long i = 1; i*i <= num; i += 2)
                        if (num%i == 0)
                            numTotal += 2;
                }
            }

            else if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else if (num < 0)
            {
                return GetDivisorCount(num *= -1);
            }

            return numTotal;
        }
    }
}