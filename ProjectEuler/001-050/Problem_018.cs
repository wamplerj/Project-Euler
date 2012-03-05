using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem_018
    {

        private List<List<int>> _triangle = new List<List<int>>();
        private Dictionary<string, int> _calculatedValues = new Dictionary<string, int>();

        public void LoadTriangle(string fileName)
        {
            using(var reader = new StreamReader(Environment.CurrentDirectory + "\\Data\\" + fileName))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(new[] {' '}).Select(i => int.Parse(i)).ToList();

                    _triangle.Add(values);
                }
            }

        }

        private void SetLargestSum(int i, int j, int currentSum)
        {

            string leftKey = CreateKey(i + 1, j);
            string rightKey = CreateKey(i + 1, j + 1);

            int leftSum = currentSum + _triangle[i + 1][j];
            if(!_calculatedValues.ContainsKey(leftKey))
            {
                _calculatedValues.Add(leftKey, leftSum);
            }
            else
            {
                int currentLeftSum = _calculatedValues[leftKey];
                if (leftSum > currentLeftSum)
                    _calculatedValues[leftKey] = leftSum;
            }

            int rightSum = currentSum + _triangle[i + 1][j + 1];
            _calculatedValues.Add(rightKey, rightSum);

        }



        public int FindLargestSum()
        {
            int largestSum = 0;

            for (int i = 0; i < _triangle.Count - 1; i++ )
            {
                for(int j = 0; j < _triangle[i].Count; j++ )
                {
                    string currentKey = CreateKey(i, j);

                    var currentSum = _calculatedValues.ContainsKey(currentKey)
                                         ? _calculatedValues[currentKey]
                                         : _triangle[i][j];

                    SetLargestSum(i, j, currentSum);

                }
            }

            int lastRow = _triangle.Count - 1;
            for(int j = 0; j < _triangle[lastRow].Count; j++)
            {
                string key = CreateKey(lastRow, j);

                int sum = _calculatedValues[key];
                if (sum > largestSum)
                    largestSum = sum;
            }

            return largestSum;
        }

        private string CreateKey(int i, int j)
        {
            return string.Format("{0}x{1}", i, j);
        }
    }
}
