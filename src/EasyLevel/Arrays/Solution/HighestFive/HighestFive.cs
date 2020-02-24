
using System.Collections.Generic;
using System.Linq;

namespace Arrays.Solution.HighestFive
{
    public class HighestFive
    {
        private readonly Dictionary<int, List<int>> _idsWithGrades = new Dictionary<int, List<int>>();

        public int[][] HighFive(int[][] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (_idsWithGrades.ContainsKey(items[i][0]))
                {
                    _idsWithGrades[items[i][0]].Add(items[i][1]);
                }
                else
                {
                    _idsWithGrades.Add(items[i][0], new List<int>() {items[i][1]});
                }
            }

            var studentIds = _idsWithGrades.Keys.ToList();
            studentIds.Sort();

            int[][] arr = new int[studentIds.Count][];

            for (int k = 0; k < studentIds.Count; k++)
            {
                var grades = _idsWithGrades[studentIds[k]];
                grades.Sort();

                var middle = 0;

                for (int j = grades.Count - 1; j >= grades.Count - 5; j--)
                {
                    middle += grades[j];
                }

                arr[k] = new[] {studentIds[k], middle / 5};
            }

            return arr;
        }
    }
}
