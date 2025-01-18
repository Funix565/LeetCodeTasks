namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/neighboring-bitwise-xor/

    public class NeighboringBitwiseXOR
    {
        public static bool Solve(int[] derived)
        {
            if (derived.Length == 1 && derived[0] == 0)
            {
                return true;
            }

            if (derived.Length == 1)
            {
                return false;
            }

            int start = 0;
            for (int i = 0; i < derived.Length - 1; ++i)
            {
                start = start ^ derived[i];
            }

            return (start ^ 0) == derived[derived.Length - 1];
        }
    }
}
