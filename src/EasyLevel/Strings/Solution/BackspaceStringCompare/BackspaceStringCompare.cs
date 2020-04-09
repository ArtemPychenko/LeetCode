using System.Linq;

namespace Strings.Solution.BackspaceStringCompare
{
    public class BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            string s = null;
            string t = null;
            int counter = 0;

            if (S == null && T == null)
            {
                return true;
            }

            if (S == null || T == null)
            {
                return false;
            }

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '#')
                {
                    counter++;
                    continue;
                }

                if (S[i] != '#' && counter == 0)
                {
                    s += S[i];
                }
                else if (S[i] != '#' && counter > 0)
                {
                    counter--;
                }
            }

            counter = 0;

            for (int i = T.Length - 1; i >= 0; i--)
            {
                if (T[i] == '#')
                {
                    counter++;
                    continue;
                }

                if (T[i] != '#' && counter == 0)
                {
                    t += T[i];
                }
                else if (T[i] != '#' && counter > 0)
                {
                    counter--;
                }
            }

            if (s == null && t == null)
            {
                return true;
            }

            if (s == null || t == null)
            {
                return false;
            }

            s = string.Concat(s.OrderBy(x => x));
            t = string.Concat(t.OrderBy(x => x));

            return s.Equals(t);
        }
    }
}
