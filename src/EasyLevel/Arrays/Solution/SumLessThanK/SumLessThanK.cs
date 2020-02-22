namespace Arrays.Solution.SumLessThanK
{
    public class SumLessThanK
    {
        public int TwoSumLessThanK(int[] arr, int k)
        {
            int maxToK = -1;

            if (arr.Length < 2)
            {
                return maxToK;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] + arr[j] < k && arr[i] + arr[j] > maxToK)
                    {
                        maxToK = arr[i] + arr[j];
                    }
                }
            }

            return maxToK;
        }
    }
}
