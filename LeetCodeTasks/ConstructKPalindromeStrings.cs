namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/construct-k-palindrome-strings/

    public class ConstructKPalindromeStrings
    {
        public static bool Solve(string s, int k)
        {
            if (s.Length < k)
            {
                return false;
            }

            // count the number of characters that have odd count
            int[] countPerLetter = new int[26];
            foreach (char c in s)
            {
                int index = c - 'a';
                countPerLetter[index] = countPerLetter[index] + 1;
            }

            int oddCount = 0;
            foreach (int i in countPerLetter)
            {
                if (i % 2 != 0)
                {
                    ++oddCount;
                }
            }

            if (oddCount > k)
            {
                return false;
            }

            return true;
        }
    }
}
