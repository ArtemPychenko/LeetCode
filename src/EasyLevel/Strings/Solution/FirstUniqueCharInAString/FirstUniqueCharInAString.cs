using System;
using System.Collections.Generic;

namespace Strings.Solution.FirstUniqueCharInAString
{
    public class FirstUniqueCharInAString
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            var stringKey = "";

            foreach (char ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] += 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            foreach (var strKey in dict.Keys)
            {
                if (dict[strKey] == 1)
                {
                    stringKey = strKey.ToString();
                    break;
                }
            }

            return stringKey.Equals("") ? -1 : s.IndexOf(stringKey, StringComparison.Ordinal);
        }
    }
}
