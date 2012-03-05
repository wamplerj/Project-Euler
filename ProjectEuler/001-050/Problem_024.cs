using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_024
    {

        private int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public string CalculateNthPermutation(int n)
        {
            string value = string.Empty;
            int count = 1;
 
            while(count < n)
            {
                value = string.Empty;
                int totalNumbers = numbers.Length;
                int i = totalNumbers - 1;

                //Find the first index in the array where a number is larger then the next index
                while(numbers[i - 1] >= numbers[i] )
                {
                    i = i - 1;
                }

                int j = totalNumbers;

                while (numbers[j - 1] <= numbers[i - 1])
                {
                    j = j - 1;
                }

                Swap(i - 1, j - 1);

                i++;
                j = totalNumbers;
                while (i < j)
                {
                    Swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                count++;

                for (int k = 0; k < numbers.Length; k++)
                {
                    value = value + numbers[k];
                }
            }


            //for (int i = 0; i < numbers.Length; i++ )
            //{
            //    var currentNumber = numbers[i];


            //    for (int j = 0; j < numbers.Length; j++ )
            //    {
            //        var valueToBuild = new StringBuilder();
            //        valueToBuild.Append(currentNumber);

            //        if (count == n)
            //            return value;

            //        if (numbers[j] == currentNumber)
            //            continue;

            //        for (int k = 0; k < numbers.Length; k++)
            //        {
            //            int index = j + k;

            //            if (index >= numbers.Length)
            //                index -= numbers.Length;

            //            if (numbers[index] == currentNumber)
            //                continue;

            //            valueToBuild.Append(numbers[index]);
                                               
            //        }

            //        value = valueToBuild.ToString();
            //        count++;
  
            //    }
            //}

            return value;
        }

        private void Swap(int i, int j)
        {
            int k = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = k;
        }
    }
}
