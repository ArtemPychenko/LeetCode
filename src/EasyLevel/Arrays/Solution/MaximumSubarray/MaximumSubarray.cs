
namespace Arrays.Solution.MaximumSubarray
{
    public class MaximumSubarray
    {
        // Brut force
        public int MaxSubArrayBrutForce(int[] nums)
        {
            int max = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum > max)
                    {
                        max = sum;
                    }
                }

                sum = 0;
            }

            return max;
        }
    }
}
