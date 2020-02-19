using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyLevel.Strings.Solution.SmallestCharacterFrequencyComparer
{
    public class SmallestCharacterFrequencyComparer
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var queriesArray = new int[queries.Length];
            var wordsArray = new int[words.Length];
            var finalArray = new int[queries.Length];

            for (int k = 0; k < words.Length; k++)
            {
                wordsArray[k] = CountSmallestCharacter(words[k]);
            }

            var sortedWordsArray = Sort(wordsArray);

            for (int i = 0; i < queries.Length; i++)
            {
                queriesArray[i] = CountSmallestCharacter(queries[i]);
                int comparison = SearchForBiggerNumbers(queriesArray[i], sortedWordsArray);
                finalArray[i] = comparison;
            }

            return finalArray;
        }

        private int CountSmallestCharacter(string word)
        {
            var charCounter = new Dictionary<char, int>();

            foreach (var character in word)
            {
                if (charCounter.ContainsKey(character))
                {
                    charCounter[character] += 1;
                }
                else
                {
                    charCounter.Add(character, 1);
                }
            }

            var arrayToSort = charCounter.Keys.ToArray();
            Array.Sort(arrayToSort);

            return charCounter[arrayToSort[0]];
        }

        private int[] Sort(int[] initialArray)
        {
            Array.Sort(initialArray);

            return initialArray;
        }

        private int SearchForBiggerNumbers(int numberToCompare, int[] arrayToCompare)
        {
            for (int i = 0; i < arrayToCompare.Length; i++)
            {
                if (arrayToCompare[i] > numberToCompare)
                {
                    return arrayToCompare.Length - i;
                }
            }

            return 0;
        }
    }
}
