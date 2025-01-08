namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/count-prefix-and-suffix-pairs-i/

    public class CountPrefixAndSuffixPairsI
    {
        public static int Solve(string[] words)
        {
            int answer = 0;

            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = i + 1; j < words.Length; ++j)
                {
                    if (IsPrefixAndSuffix(words[i], words[j]))
                    {
                        ++answer;
                    }
                }
            }

            return answer;
        }

        private static bool IsPrefixAndSuffix(string str1, string str2)
        {
            return str2.StartsWith(str1) && str2.EndsWith(str1);
        }
    }
}
