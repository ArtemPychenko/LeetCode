
namespace Math.Solution.AddBinaries
{
    public class AddBinaries
    {
        public string AddBinary(string a, string b)
        {
            char[] result, operand;

            if (b.Length > a.Length)
            {
                result = b.ToCharArray();
                operand = a.ToCharArray();
            }
            else
            {
                result = a.ToCharArray();
                operand = b.ToCharArray();
            }

            int diff = result.Length - operand.Length;
            bool transfer = false;

            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (transfer)
                {
                    if (result[i] == '1')
                    {
                        result[i] = '0';
                    }
                    else
                    {
                        result[i] = '1';
                        transfer = false;
                    }
                }

                char op = (i - diff >= 0) ? operand[i - diff] : '0';

                if (result[i] == '1' && op == '1')
                {
                    result[i] = '0';
                    transfer = true;
                    continue;
                }

                if ((result[i] == '0' && op == '1') || (result[i] == '1' && op == '0'))
                {
                    result[i] = '1';
                    continue;
                }

                if (!transfer && i - diff <= 0) break;
            }

            string resString = new string(result);
            if (transfer)
            {
                resString = "1" + resString;
            }
            return resString;
        }
    
}
}
