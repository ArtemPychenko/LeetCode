
using System.Collections.Generic;

namespace EasyLevel.Strings.Solution.ValidParenthesis
{
    public class ValidParenthesis
    {
        private readonly Dictionary<char, char> _parenthesis;

        public ValidParenthesis()
        {
            _parenthesis = new Dictionary<char, char>
            {
                {'(', ')'},
                {'{', '}'}, 
                {'[', ']'}
            };

        }

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            if (s.Length == 0)
            {
                return true;
            }

            if (s.Length % 2 != 0)
            {
                return false;
            }

            foreach (var t in s)
            {
                if (stack.Count == 0)
                {
                    if (!_parenthesis.ContainsKey(t))
                    {
                        return false;
                    }
                    stack.Push(t);
                }
                else
                {
                    var item = stack.Peek();
                    if (_parenthesis.ContainsKey(t))
                    {
                        stack.Push(t);
                    }
                    else if (_parenthesis[item] == t)
                    {
                        stack.Pop();
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
