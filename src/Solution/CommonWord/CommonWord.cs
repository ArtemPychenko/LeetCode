using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyLevel.Strings.Solution.CommonWord
{
    public class CommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = paragraph.ToLower();
            paragraph += ".";

            var separators = new []
            {
                ' ', ',', '!', '?', ':', ';', '.', '\''
            };
            var wordsDict = new Dictionary<string, int>();

            var sb = new StringBuilder();

            foreach (var t in paragraph)
            {
                if (!separators.Contains(t))
                {
                    sb.Append(t);
                }
                else if (!banned.Contains(sb.ToString()) && wordsDict.ContainsKey(sb.ToString()) && sb.Length != 0)
                {
                    wordsDict[sb.ToString()] += 1;
                    sb.Clear();
                }
                else if (!banned.Contains(sb.ToString()) && !wordsDict.ContainsKey(sb.ToString()) && sb.Length != 0)
                {
                    wordsDict.Add(sb.ToString(), 1);
                    sb.Clear();
                }
                else if (banned.Contains(sb.ToString()) && sb.Length != 0)
                {
                    sb.Clear();
                }
            }

            var keyWithBiggestNumber = wordsDict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            return keyWithBiggestNumber;
        }
    }
}
