    
using System;
using System.Collections.Generic;

namespace HashTable.Solution.Contiguous_Array
{
    public class ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
            var longest = 0;
            var counter = 0;

            var dict = new Dictionary<int, int>
            {
                {0, -1}
            };

            for (int i = 0; i < nums.Length; i++)
            {
                counter += nums[i] == 1 ? 1 : -1;

                if (dict.ContainsKey(counter))
                {
                    longest = Math.Max(longest, i - dict[counter]);
                }
                else
                {
                    dict.Add(counter, i);
                }
            }

            return longest;
        }
    }
}
