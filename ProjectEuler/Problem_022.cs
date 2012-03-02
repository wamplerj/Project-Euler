using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem_022
    {
        private readonly int characterOffset = 64;

        public long CalculateAllNameScores()
        {
            long sum = 0;

            var names = GetNamesFromFile();

            for(int i = 0; i < names.Count; i++)
            {
                var nameScore = GetNameScore(names[i]);
                nameScore = nameScore*(i + 1);

                sum += nameScore;
            }

            return sum;
        }

        public int GetNameScore(string name)
        {
            int sum = 0;

            foreach(var letter in name.Trim().ToUpper())
            {
                int value = (int) letter - characterOffset;

                Debug.Assert(value >= 1 || value <= 26, "Letter is " + letter);

                sum += value;
            }

            return sum;
        }

        private List<string> GetNamesFromFile()
        {
            StringBuilder temp = new StringBuilder();
            var names = new List<string>();

            using (var reader = new StreamReader(Environment.CurrentDirectory + "\\Data\\022.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    temp.AppendLine(reader.ReadLine());
                }
            }

            temp = temp.Replace("\"", "");
            names = temp.ToString().Split(new[] {','}).ToList();
            names.Sort();

            return names;
        }
    }
}
