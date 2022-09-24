using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/

    public class KWeakestRowsInMatrix
    {
        public static int[] Solve(int[][] mat, int k)
        {
            // - Use max-heap (priority queue with reversed IComparer)
            // - Iterate each row and find the number of soldiers using binary search
            // - Enqueue {row_index:soldiers} into max-heap. soldiers is Priority
            // - Maintain the max-heap size to at max k. Otherwise, dequeue
            // - In the end, dequeue each element and save as answer
            // - Lastly, reverse the answer

            // https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/discuss/1066773/C++-or-Max-Heap-+-Binary-Search-or-O(m*log(max(n-k))-0ms-Beats-100-or-Explanation-(Tips)

            // <row_index, Tuple<priority,row_index>>
            PriorityQueue<int, Tuple<int, int>> pq = new(Comparer<Tuple<int, int>>.Create(
                (x, y) =>
                {
                    // The number of soldiers in row i is less than the number of soldiers in row j
                    if (x.Item1.CompareTo(y.Item1) < 0)
                    {
                        return 1;
                    }
                    // Both rows have the same number of soldiers and i < j
                    else if (x.Item1.CompareTo(y.Item1) == 0 && x.Item2.CompareTo(y.Item2) < 0)
                    {
                        return 1;
                    }

                    return -1;
                }));

            for (int i = 0; i < mat.Length; ++i)
            {
                int low = 0;
                int high = mat[i].Length - 1;
                while (low <= high)
                {
                    // IMPORTANT!
                    int mid = low + (high - low) / 2;

                    if (mat[i][mid] == 0)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                pq.Enqueue(i, new Tuple<int, int>(low, i));
                if (pq.Count>k)
                {
                    pq.Dequeue();
                }
            }

            int[] result = new int[k];
            int j = 0;
            while (pq.Count > 0)
            {
                result[j++] = pq.Dequeue();
            }

            Array.Reverse(result);

            return result;
        }
    }
}
