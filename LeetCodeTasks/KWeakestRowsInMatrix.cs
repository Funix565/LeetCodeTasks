using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/

    public class KWeakestRowsInMatrix
    {
        public static int[] Solve(int[][] mat, int k)
        {
            // We have to return the indices of the k weakest rows, that's why size is k
            int[] result = new int[k];

            // To keep soldiers:row as in the explanations
            List<Tuple<int,int>> SoldiersPerRow = new();

            for (int row = 0; row < mat.Length; ++row)
            {
                int count = 0;
                foreach(int n in mat[row])
                {
                    if (n != 1)
                    {
                        break;
                    }

                    ++count;
                }

                Tuple<int, int> t = new(count, row);
                SoldiersPerRow.Add(t);
            }

            // Sort the tuples by number of soldiers, ascending.
            // If both rows have the same number of soldiers, then sort by row index.
            // That's how we get the weakest rows in the beginning.
            SoldiersPerRow.Sort(
                (x, y) => x.Item1.CompareTo(y.Item1) == 0 ? x.Item2.CompareTo(y.Item2) : x.Item1.CompareTo(y.Item1)
            );

            // No need in full loop, just save the k values
            for (int i = 0; i < k; ++i)
            {
                result[i] = SoldiersPerRow[i].Item2;
            }

            return result;
        }
    }
}
