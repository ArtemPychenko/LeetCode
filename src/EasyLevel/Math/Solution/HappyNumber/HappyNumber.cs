
using System.Collections.Generic;

namespace Math.Solution.HappyNumber
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var existing = new HashSet<int>();

            while (n != 1 && !existing.Contains(n))
            {
                existing.Add(n);
                n = GetSquareSum(n);
            }

            return n == 1;
        }

        private int GetSquareSum(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int t = n % 10;
                n = n / 10;
                totalSum += t * t;
            }

            return totalSum;
        }
    }
}
