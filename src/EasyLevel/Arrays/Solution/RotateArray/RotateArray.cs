
namespace Arrays.Solution.RotateArray
{
    public class RotateArray
    {
        public int[] Rotate(int[] nums, int k)
        {
            int[] temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                temp[(i + k) % nums.Length] = nums[i];
            }

            return temp;
        }
    }
}
