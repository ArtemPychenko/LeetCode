using System;

namespace Arrays.Solution.MergeSortedArrays
{
    public class MergeSortedArrays
    {
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);

            Array.Sort(nums1);

            return nums1;
        }
    }
}
