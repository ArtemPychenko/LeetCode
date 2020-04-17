
using System;

namespace Strings.Solution.ValidParenthesisString
{
    public class ValidParenthesisString
    {
        public bool CheckValidString(string s)
        {
            int left = 0, right = 0;

            foreach (var c in s)
            {
                left += c == '(' ? 1 : -1;
                right += c != ')' ? 1 : -1;

                if (right < 0)
                {
                    break;
                }

                left = Math.Max(left, 0);
            }

            return left == 0;
        }
    }
}
