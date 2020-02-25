
using System.Collections.Generic;
using System.Linq;

namespace Math.Solution.RomanToInteger
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var sum = 0;
            var romans = new Dictionary<char, int>();
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);
            if (!s.Any())
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return romans[s[0]];
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (romans.ContainsKey(s[i]))
                {
                    if (s[i] == 'I' && s[i + 1] == 'V')
                    {
                        sum += 4;
                        i++;
                        continue;
                    }

                    if (s[i] == 'I' && s[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                        continue;
                    }

                    if (s[i] == 'X' && s[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                        continue;
                    }

                    if (s[i] == 'X' && s[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                        continue;
                    }

                    if (s[i] == 'C' && s[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                        continue;
                    }

                    if (s[i] == 'C' && s[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                        continue;
                    }

                    sum += romans[s[i]];
                }
                else
                {
                    return 0;
                }
            }

            string twoLast = s.Substring(s.Length - 2);
            var breakingCombinations = new List<string>();
            breakingCombinations.Add("IV");
            breakingCombinations.Add("IX");
            breakingCombinations.Add("XL");
            breakingCombinations.Add("XC");
            breakingCombinations.Add("CD");
            breakingCombinations.Add("CM");

            if (!breakingCombinations.Contains(twoLast))
            {
                sum += romans[s[s.Length - 1]];
            }

            return sum;
        }
    }
}
