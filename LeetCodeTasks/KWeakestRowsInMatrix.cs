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

            // Fill it with -1 for future check
            int filler = mat.Length + 500;
            Array.Fill(result, filler);

            // Global shift for result. Used, when both rows have the same number of soldiers
            int shift = 0;

            // To track fullness of result
            int hit = 0;

            for (int r = 0; r < mat.Length; ++r)
            {
                // Calculate the number of soldiers in each row
                int count = 0;
                foreach (int n in mat[r])
                {
                    if (n == 1)
                    {
                        ++count;
                    }
                    else
                    {
                        break;
                    }
                }

                // Should all rows contain at leats one soldier?
                // Should all rows contain at least one civilian?
                // shift can't be global?

                // We need count < k because position in result is based on it. Otherwise -- overflow
                if (count > 0 && count < k)
                {
                    // count - 1 because I noticed this pattern.
                    // the number of soldiers relates to position in 1-based array, that's why -1
                    if(result[count - 1] == filler)
                    {
                        result[count - 1] = r;
                    }
                    else
                    {
                        // both rows have the same number of soldiers, mainatin result order with shift
                        result[count - 1 + ++shift] = r;
                    }

                    ++hit;
                    // We can stop here because result is ready.
                    if (hit == result.Length)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
