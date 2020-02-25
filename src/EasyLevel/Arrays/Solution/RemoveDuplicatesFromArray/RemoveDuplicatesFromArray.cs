
namespace Arrays.Solution.RemoveDuplicatesFromArray
{
    public class RemoveDuplicatesFromArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var counter = 1;
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return 1;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }

            return counter;
        }
    }
}
