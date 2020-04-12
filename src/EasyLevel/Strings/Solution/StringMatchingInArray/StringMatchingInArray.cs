using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings.Solution.StringMatchingInArray
{
    public class StringMatchingInArray
    {
        public IList<string> StringMatching(string[] words)
        {
            if (!words.Any())
            {
                return null;
            }

            IList<string> substrings = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (words[j].Contains(words[i]))
                    {
                        substrings.Add(words[i]);
                        break;
                    }
                }
            }

            return substrings;
        }
    }
}
