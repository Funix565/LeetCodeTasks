using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/bitwise-xor-of-all-pairings/
    // Calculator: https://bitwisecmd.com/

    public class BitwiseXOROfAllPairings
    {
        public static int Solve(int[] nums1, int[] nums2)
        {
            if ((nums1.Length & 1) == 0 && (nums2.Length & 1) == 0)
            {
                return 0;
            }

            if ((nums1.Length & 1) == 1 && (nums2.Length & 1) == 0)
            {
                int answer = 0;
                foreach (int i in nums2)
                {
                    answer = answer ^ i;
                }

                return answer;
            }

            if ((nums1.Length & 1) == 0 && (nums2.Length & 1) == 1)
            {
                int answer = 0;
                foreach (int i in nums1)
                {
                    answer = answer ^ i;
                }

                return answer;
            }

            if ((nums1.Length & 1) == 1 && (nums2.Length & 1) == 1)
            {
                int answer = 0;
                foreach (int i in nums1)
                {
                    answer = answer ^ i;
                }

                foreach (int i in nums2)
                {
                    answer = answer ^ i;
                }

                return answer;
            }

            return -1;
        }
    }
}
