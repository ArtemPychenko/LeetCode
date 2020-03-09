
using System.Collections.Generic;

namespace Strings.Solution.FizzBuzz
{
    public class FizzBuzz
    {
        public IList<string> IsFizzBuzz(int n)
        {
            var fizzBuzz = new List<string>();

            if (n < 1)
            {
                return fizzBuzz;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzz.Add("FizzBuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    fizzBuzz.Add("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    fizzBuzz.Add("Buzz");
                    continue;
                }

                fizzBuzz.Add((i).ToString());
            }

            return fizzBuzz;
        }
    }
}
