
using System;
using System.Linq;

namespace Arrays.Solution.ThirdMaximumNumber
{
    public class ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            var counter = 1;
            Array.Sort(nums);

            if (nums.Length == 1 && nums.Any())
            {
                return nums[0];
            }

            if (nums.Length == 2 && nums.Any())
            {
                return nums[1];
            }

            if (!nums.Any())
            {
                return 0;
            }

            Array.Reverse(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    counter++;
                }

                if (counter == 3)
                {
                    return nums[i];
                }
            }

            if (counter == 2)
            {
                return nums[0];
            }

            if (counter == 1)
            {
                return nums[0];
            }

            return 0;
        }
    }
}
