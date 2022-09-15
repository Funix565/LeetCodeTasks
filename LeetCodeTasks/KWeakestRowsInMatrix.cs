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

                // expected rows of 'matrix' to have 2 <= size <= 100
                // Don't create new DS for the number of soldiers in each row.
                // Reuse input matrix.
                mat[row][0] = count;
                mat[row][1] = row;
            }

            // Sort matrix by 0-column where we have the soldier count. Here we swap rows
            var ordered = mat.OrderBy(i => i[0]).ToArray();

            // Fill result, just save the k values
            for (int i = 0; i < k; ++i)
            {
                result[i] = ordered[i][1];
            }

            return result;
        }
    }
}
