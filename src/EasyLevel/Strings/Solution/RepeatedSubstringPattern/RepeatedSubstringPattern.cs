
namespace Strings.Solution.RepeatedSubstringPattern
{
    public class RepeatedSubstringPattern
    {
        public bool IsRepeatedSubstringPattern(string s)
        {
            var n = s.Length;

            for (int count = n / 2; count > 0; count--)
            {
                if (n % count != 0) continue;
                var leftStr = s.Substring(0, count);

                var isFinished = true;
                for (int i = count; i < n; i += count)
                {
                    if (leftStr != s.Substring(i, count))
                    {
                        isFinished = false;
                        break;
                    }
                }

                if (isFinished) return true;
            }

            return false;
        }
    }
}
