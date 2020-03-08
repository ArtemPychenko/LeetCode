
namespace _179.StringWithOddCounts
{
    public class StringWithOddCounts
    {
        public string GenerateTheString(int n)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            if (n > 26)
            {
                if ((n - 25) % 2 == 1)
                {
                    var oddStr = new string('a', n - 25);

                    return alphabet.Substring(1) + oddStr;
                }
                else
                {
                    var oddStr = new string('a', n - 24);

                    return alphabet.Substring(2) + oddStr;
                }
            }

            if (n == 26)
            {
                return alphabet;
            }

            if (n < 26)
            {
                return alphabet.Substring(0, n);
            }

            return "";
        }
    }
}
