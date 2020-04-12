using System.Collections.Generic;
using System.Linq;

namespace Arrays.Solution.QueriesOnPermutation
{
    public class QueriesOnPermutation
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            var permutations = new int[m];
            var positions = new List<int>();

            for (int i = 0; i < m; i++)
            {
                permutations[i] = i + 1;
            }

            for (int j = 0; j < queries.Length; j++)
            {
                if (permutations.Contains(queries[j]))
                {
                    int pos = 0;
                    for (int b = 0; b < permutations.Length; b++)
                    {
                        if (permutations[b] == queries[j])
                        {
                            pos = b;
                            break;
                        }
                    }

                    positions.Add(pos);

                    for (int k = pos; k > 0; k--)
                    {
                        var temp = permutations[k];
                        permutations[k] = permutations[k - 1];
                        permutations[k - 1] = temp;
                    }
                }
            }

            return positions.ToArray();
        }
    }
}
