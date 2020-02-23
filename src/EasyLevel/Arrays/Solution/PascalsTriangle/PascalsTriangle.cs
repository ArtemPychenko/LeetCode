
using System.Collections.Generic;

namespace Arrays.Solution.PascalsTriangle
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                // first position in list will always be 1
                result.Add(new List<int>() { 1 });

                // starts at 1 because the calculated values start at index 1 in each list
                for (int j = 1; j < i; j++)
                    result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);

                // last position in every line is 1, except the first one
                if (i > 0)
                    result[i].Add(1);
            }

            return result;
        }
    }
}
