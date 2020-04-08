using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Arrays.Solution.CountingElement
{
    public class CountingElements
    {
        public int CountElements(int[] arr)
        {
            if (!arr.Any())
            {
                return 0;
            }

            var additions = new HashSet<int>();
            var counter = 0;

            foreach (var elem in arr)
            {
                additions.Add(elem);
            }

            foreach (var elem in arr)
            {
                if (additions.Contains(elem + 1))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
