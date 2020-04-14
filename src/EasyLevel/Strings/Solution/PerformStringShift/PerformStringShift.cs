
using System.Linq;

namespace Strings.Solution.PerformStringShift
{
    public class PerformStringShift
    {
        public string StringShift(string s, int[][] shift)
        {
            if (!s.Any())
            {
                return null;
            }

            if (s.Length == 1)
            {
                return s;
            }

            foreach (var item in shift)
            {
                if (item[1] % s.Length == 0)
                {
                    continue;
                }

                var final = "";
                item[1] = item[1] > s.Length ? item[1] % s.Length : item[1];
                
                if (item[0] == 0)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        var index = i + item[1];
                        index = index >= s.Length ? index % s.Length : index;
                        final += s[index];
                    }

                    s = final;
                }
                else if (item[0] == 1)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        var index = i - item[1];
                        index = index < 0 ? s.Length + index : index;
                        final += s[index];
                    }

                    s = final;
                }
            }

            return s;
        }
    }
}
