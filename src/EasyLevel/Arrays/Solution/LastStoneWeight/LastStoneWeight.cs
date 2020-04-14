
using System.Collections.Generic;
using System.Linq;

namespace Arrays.Solution.LastStoneWeight
{
    public class LastStoneWeight
    {
        public int GetLastStoneWeight(int[] stones)
        {
            if (stones.Length == 0)
            {
                return 0;
            }

            var stonesList = stones.ToList();

            return GetHeaviest(stonesList);
        }

        private int GetHeaviest(List<int> stonesList)
        {
            if (stonesList.Count < 1)
            {
                return 0;
            }

            if (stonesList.Count < 2)
            {
                return stonesList[0];
            }

            //stonesList = MergeSort(stonesList);

            stonesList.Sort();
            var last = stonesList.Count - 1;
            var prelast = last - 1;

            if (stonesList[last] == stonesList[prelast])
            {
                stonesList.RemoveRange(prelast, 2);
            }
            else if (stonesList[last] > stonesList[prelast])
            {
                var itemToAdd = stonesList[last] - stonesList[prelast];
                stonesList.RemoveRange(prelast, 2);
                stonesList.Add(itemToAdd);
            }
            else if (stonesList[last] < stonesList[prelast])
            {
                var itemToAdd = stonesList[prelast] - stonesList[last];
                stonesList.RemoveRange(prelast, 2);
                stonesList.Add(itemToAdd);
            }

            int heaviest = GetHeaviest(stonesList);

            return heaviest;
        }

        private List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count == 1)
            {
                return unsorted;
            }

            var left = new List<int>();
            var right = new List<int>();

            left = unsorted.GetRange(0, unsorted.Count / 2);
            right = unsorted.GetRange(unsorted.Count / 2, unsorted.Count / 2);

            left = MergeSort(left);
            right = MergeSort(right);
            int i = 0, j = 0;

            for (int k = 0; k < unsorted.Count; k++)
            {
                if (i < left.Count && j < right.Count)
                {
                    if (left[i] < right[j])
                    {
                        unsorted[k] = left[i];
                        i++;
                    }
                    else
                    {
                        unsorted[k] = right[j];
                        j++;
                    }
                }
                else if (i < left.Count && j == right.Count)
                {
                    unsorted[k] = left[i];
                    i++;
                }
                else if (i == left.Count && j < right.Count)
                {
                    unsorted[k] = right[j];
                    j++;
                }
            }

            return unsorted;
        }
    }
}
