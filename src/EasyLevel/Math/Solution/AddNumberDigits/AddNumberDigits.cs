
namespace Math.Solution.AddNumberDigits
{
    public class AddNumberDigits
    {
        public int AddDigits(int num)
        {
            var total = 0;

            while (num > 0)
            {
                total += num % 10;
                num = num / 10;

                if (num == 0 && total / 10 != 0)
                {
                    num = total;
                    total = 0;
                }
            }

            return total;
        }
    }
}
