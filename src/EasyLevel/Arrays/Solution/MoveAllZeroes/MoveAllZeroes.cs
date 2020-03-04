
namespace Arrays.Solution.MoveAllZeroes
{
    public class MoveAllZeroes
    {
        public int[] MoveZeroes(int[] nums)
        {
            var pointer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && i == pointer)
                {
                    pointer++;
                }
                else if (nums[i] != 0 && i != pointer)
                {
                    nums[pointer] = nums[i];
                    nums[i] = 0;
                    pointer++;
                }
            }

            return nums;
        }
    }
}
