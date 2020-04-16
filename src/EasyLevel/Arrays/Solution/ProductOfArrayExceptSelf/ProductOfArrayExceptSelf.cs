
namespace Arrays.Solution.ProductOfArrayExceptSelf
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var before = new int[nums.Length];
            var after = new int[nums.Length];

            before[0] = 1;
            after[after.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                before[i] = before[i - 1] * nums[i - 1];
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                after[i] = after[i + 1] * nums[i + 1];
            }

            for (int k = 0; k < before.Length; k++)
            {
                before[k] *= after[k];
            }

            return before;
        }
    }
}
