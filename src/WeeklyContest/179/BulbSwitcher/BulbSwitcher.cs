
using System;

namespace _179.BulbSwitcher
{
    public class BulbSwitcher
    {
        public int NumTimesAllBlue(int[] light)
        {
            var right = 0;
            var result = 0; 
            var length = light.Length;

            for (int i = 0; i < length; ++i)
            {
                right = Math.Max(right, light[i]);

                if (right == i + 1)
                {
                    ++result;
                }
                    
            }
            return result;
        }
    }
}
