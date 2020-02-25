
using System.Collections.Generic;

namespace Math.Solution.Subtraction
{
    public class Subtraction
    {
        public int SubtractProductAndSum(int n)
        {
            var digits = new List<int>();

            if (n == 0)
            {
                return 0;
            }

            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            var sum = 0;
            var prod = 1;

            foreach (var digit in digits)
            {
                sum += digit;
                prod *= digit;
            }

            return prod - sum;
        }
    }
}
