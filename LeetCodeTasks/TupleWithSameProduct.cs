using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/tuple-with-same-product/

    public class TupleWithSameProduct
    {
        public static int TupleSameProduct(int[] nums)
        {
            Dictionary<long, int> products = new Dictionary<long, int>();
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    long product = nums[i] * nums[j];

                    if (products.TryGetValue(product, out int value))
                    {
                        products[product] = value + 1;
                    }
                    else
                    {
                        products.Add(product, 1);
                    }
                }
            }

            int answer = 0;
            foreach (var value in products.Values)
            {
                if (value > 1)
                {
                    answer = answer + 8 * (value * (value - 1) / 2);
                }
            }

            return answer;
        }
    }
}
