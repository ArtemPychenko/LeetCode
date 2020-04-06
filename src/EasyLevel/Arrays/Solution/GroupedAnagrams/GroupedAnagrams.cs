using System.Collections.Generic;
using System.Linq;

namespace Arrays.Solution.GroupedAnagrams
{
    public class GroupedAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var sorted = Sort(strs);
            var dictionary = new Dictionary<string, IList<string>>();
            IList<IList<string>> sortedList = new List<IList<string>>();

            if (!strs.Any())
            {
                return null;
            }

            for (int i = 0; i < sorted.Length; i++)
            {
                if (dictionary.ContainsKey(sorted[i]))
                {
                    dictionary[sorted[i]].Add(strs[i]);
                }
                else
                {
                    dictionary.Add(sorted[i], new List<string>() {strs[i]});
                }
            }

            foreach (var dictionaryValue in dictionary.Values)
            {
                sortedList.Add(dictionaryValue);
            }

            return sortedList;
        }

        private string[] Sort(string[] strings)
        {
            string[] sorted = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                sorted[i] = string.Concat(strings[i].OrderBy(x => x));
            }

            return sorted;
        }
    }
}
