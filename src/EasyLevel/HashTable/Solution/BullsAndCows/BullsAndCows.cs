
using System.Collections.Generic;

namespace HashTable.Solution.BullsAndCows
{
    public class BullsAndCows
    {
        public string GetHint(string secret, string guess)
        {
            var firstSecret = new Dictionary<int, int>();
            var guessed = new List<int>();
            var counterA = 0;
            var counterB = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    counterA += 1;
                    guessed.Add(i);
                    continue;
                }

                if (firstSecret.ContainsKey(secret[i]))
                {
                    firstSecret[secret[i]] += 1;
                }
                else
                {
                    firstSecret.Add(secret[i], 1);
                }
            }

            for (int i = 0; i < guess.Length; i++)
            {
                if (firstSecret.ContainsKey(guess[i]) && firstSecret[guess[i]] > 0 && !guessed.Contains(i))
                {
                    firstSecret[guess[i]] -= 1;
                    counterB += 1;
                }
            }

            return counterA + "A" + counterB + "B";
        }
    }
}
