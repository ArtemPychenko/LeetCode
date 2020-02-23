using System.Collections.Generic;

namespace Arrays.Solution.DecompressRunLengthEncodedList
{
    public class DecompressRunLengthEncodedList
    {
        public int[] DecompressRLEList(int[] nums)
        {
            var decompressed = new List<int>();

            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                for (int k = 0; k < nums[i]; k++)
                {
                    decompressed.Add(nums[i + 1]);
                }
            }

            return decompressed.ToArray();
        }
    }
}
