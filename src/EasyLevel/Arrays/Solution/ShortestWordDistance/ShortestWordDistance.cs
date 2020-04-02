
namespace Arrays.Solution.ShortestWordDistance
{
    public class ShortestWordDistance
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            int difference = 0;
            int firstEntry = 0;
            string previousMatch = null;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1) || words[i].Equals(word2))
                {
                    if (string.Equals(previousMatch, null))
                    {
                        firstEntry = i;
                        previousMatch = words[i];
                        continue;
                    }

                    if (string.Equals(words[i], previousMatch))
                    {
                        firstEntry = i;
                    }
                    else if (!string.Equals(words[i], previousMatch))
                    {
                        if (difference > (i - firstEntry) || difference == 0)
                        {
                            difference = i - firstEntry;
                        }

                        previousMatch = words[i];
                        firstEntry = i;
                    }
                }
            }

            return difference;
        }
    }
}
