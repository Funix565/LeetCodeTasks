namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/

    public class CheckIfOneStringSwapCanMakeStringsEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2)
            {
                return true;
            }

            int mismatch = 0;
            int mismatchPos1 = -1;
            int mismatchPos2 = -1;

            for (int i = 0; i < s1.Length; ++i)
            {
                if (s1[i] != s2[i])
                {
                    ++mismatch;

                    if (mismatch == 1)
                    {
                        mismatchPos1 = i;
                    }
                    else if (mismatch == 2)
                    {
                        mismatchPos2 = i;
                    }
                }

                // The answer is false if the number of nonequal positions in the strings is not equal to 0 or 2.
                if (mismatch > 2)
                {
                    return false;
                }
            }

            // The answer is false if the number of nonequal positions in the strings is not equal to 0 or 2.
            if (mismatch == 1)
            {
                return false;
            }

            // Check that mismatched positions have the same characters.
            if (mismatch == 2)
            {
                return s1[mismatchPos1] == s2[mismatchPos2] && s1[mismatchPos2] == s2[mismatchPos1];
            }

            return false;
        }
    }
}
