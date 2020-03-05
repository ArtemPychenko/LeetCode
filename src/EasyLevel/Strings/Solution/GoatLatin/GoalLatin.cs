
using System.Collections.Generic;
using System.Text;

namespace Strings.Solution.GoatLatin
{
    public class GoalLatin
    {
        public string ToGoatLatin(string s)
        {
            var vowels = new List<char>
            {
                'i', 'I', 'e', 'E', 'a', 'A', 'o', 'O', 'u', 'U'
            };

            var words = s.Split(" ");
            var sb = new StringBuilder();

            if (s.Length == 0)
            {
                return null;
            }

            for (int i = 1; i <= words.Length; i++)
            {
                if (vowels.Contains(words[i - 1][0]))
                {
                    sb.Append(words[i - 1]);
                    sb.Append("ma");
                }
                else
                {
                    sb.Append(words[i - 1].Substring(1));
                    sb.Append(words[i - 1][0]);
                    sb.Append("ma");
                }
                var repeatedA = new string('a', i);
                sb.Append(repeatedA);
                sb.Append(" ");
            }

            return sb.ToString().Trim();
        }
    }
}
