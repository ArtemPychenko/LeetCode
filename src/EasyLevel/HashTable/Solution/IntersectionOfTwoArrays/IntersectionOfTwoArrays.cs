
using System.Collections;
using System.Collections.Generic;

namespace HashTable.Solution.IntersectionOfTwoArrays
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var existing = new List<int>();

            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return existing.ToArray();
            }

            foreach (var num in nums1)
            {
                if (((IList) nums2).Contains(num) && !existing.Contains(num))
                {
                    existing.Add(num);
                }
            }

            return existing.ToArray();
        }
    }
}
