using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/richest-customer-wealth/

    public class RichestCustomerWealth
    {
        public static int Solve(int[][] accounts)
        {
            int res = 0;
            for (int i = 0; i < accounts.Length; ++i)
            {
                int sum = accounts[i].Sum();
                res = sum > res ? sum : res;
            }

            return res;
        }
    }
}
