
namespace Arrays.Solution.PlusOne
{
    public class PlusOne
    {
        public int[] AddOne(int[] digits)
        {
            int index = digits.Length - 1;
            while (index >= 0 && digits[index] == 9)
            {
                index--;
            }

            if (index < 0)
            {
                int[] res = new int[digits.Length + 1];
                res[0] = 1;
                return res;
            }
            else
            {
                digits[index++]++;
                while (index < digits.Length)
                {
                    digits[index++] = 0;
                }
                return digits;
            }
        }
    }
}
