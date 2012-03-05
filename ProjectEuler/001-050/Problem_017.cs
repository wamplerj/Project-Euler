using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem_017
    {
        
        private Dictionary<int, int> numbersUnderTwenty = new Dictionary<int, int>();
        private Dictionary<int, int> tens = new Dictionary<int, int>();

        public Problem_017()
        {
            this.numbersUnderTwenty.Add(1, "One".Length);
            this.numbersUnderTwenty.Add(2, "Two".Length);
            this.numbersUnderTwenty.Add(3, "Three".Length);
            this.numbersUnderTwenty.Add(4, "Four".Length);
            this.numbersUnderTwenty.Add(5, "Five".Length);
            this.numbersUnderTwenty.Add(6, "Six".Length);
            this.numbersUnderTwenty.Add(7, "Seven".Length);
            this.numbersUnderTwenty.Add(8, "Eight".Length);
            this.numbersUnderTwenty.Add(9, "Nine".Length);
            this.numbersUnderTwenty.Add(10, "Ten".Length);
            this.numbersUnderTwenty.Add(11, "Eleven".Length);
            this.numbersUnderTwenty.Add(12, "Twelve".Length);
            this.numbersUnderTwenty.Add(13, "Thirteen".Length);
            this.numbersUnderTwenty.Add(14, "Fourteen".Length);
            this.numbersUnderTwenty.Add(15, "Fifteen".Length);
            this.numbersUnderTwenty.Add(16, "Sixteen".Length);
            this.numbersUnderTwenty.Add(17, "Seventeen".Length);
            this.numbersUnderTwenty.Add(18, "Eighteen".Length);
            this.numbersUnderTwenty.Add(19, "Nineteen".Length);

            this.tens.Add(20, "Twenty".Length);
            this.tens.Add(30, "Thirty".Length);
            this.tens.Add(40, "Forty".Length);
            this.tens.Add(50, "Fifty".Length);
            this.tens.Add(60, "Sixty".Length);
            this.tens.Add(70, "Seventy".Length);
            this.tens.Add(80, "Eighty".Length);
            this.tens.Add(90, "Ninety".Length);

        }

        public int CalculateLettersInWordsUnder(int topOfRange)
        {
            int count = 0;
            for(int i = 1; i <= topOfRange; i++)
            {
                count += GetWordLength(i);
            }

            return count;
        }

        private int GetWordCountForMultiplesOfTen(int i)
        {
            return tens[i*10];
        }


        private int GetWordCountUnderTwenty(int i)
        {
            return numbersUnderTwenty[i];
        }


        public int GetWordLength(int i)
        {
            int count = 0;

            if (i == 1000)
            {
                return "OneThousand".Length;
            }

            if(i >= 100)
            {
                int hundreds = i/100;

                count += GetWordCountUnderTwenty(hundreds);
                count += 7; //"hundred
                int remainder = i%100;

                if (remainder == 0) return count;

                i = remainder;
                count += 3; //"and"
               
            }

            if(i >= 20 && i <= 99)
            {
                int tens = i/10;
                count += GetWordCountForMultiplesOfTen(tens);

                int remainder = i%10;
                i = remainder;
            }


            if(i > 0 && i < 20)
            {
                count += GetWordCountUnderTwenty(i);
            }

            return count;
        }

    }
}
