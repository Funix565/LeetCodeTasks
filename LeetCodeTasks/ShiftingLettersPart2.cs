namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/shifting-letters-ii/

    public class ShiftingLettersPart2
    {
        public static string Solve(string s, int[][] shifts)
        {
            char[] sChar = s.ToCharArray();

            int[] forward = new int[sChar.Length];
            int[] backward = new int[sChar.Length];

            foreach (int[] shift in shifts)
            {
                if (shift[2] == 0)
                {
                    for (int i = shift[0]; i <= shift[1]; ++i)
                    {
                        backward[i] = (backward[i] + 1);
                    }
                }
                else if (shift[2] == 1)
                {
                    for (int i = shift[0]; i <= shift[1]; ++i)
                    {
                        forward[i] = (forward[i] + 1);
                    }
                }
            }

            for (int i = 0; i < sChar.Length; ++i)
            {
                int netShift = forward[i] - backward[i];
                netShift = (netShift % 26 + 26) % 26;

                sChar[i] = (char)((sChar[i] - 'a' + netShift) % 26 + 'a');
            }

            return new string(sChar);
        }
    }
}
