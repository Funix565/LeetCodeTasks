namespace LeetCodeTasks
{
    public class ShiftingLettersPart2
    {
        public static string Solve(string s, int[][] shifts)
        {
            char[] sChar = s.ToCharArray();

            foreach (int[] shift in shifts)
            {
                for (int i = shift[0]; i <= shift[1]; ++i)
                {
                    if (shift[2] == 0)
                    {
                        if (sChar[i] == 'a')
                        {
                            sChar[i] = 'z';
                        }
                        else
                        {
                            sChar[i] = (char)(sChar[i] - 1);
                        }
                    }
                    else if (shift[2] == 1)
                    {
                        if (sChar[i] == 'z')
                        {
                            sChar[i] = 'a';
                        }
                        else
                        {
                            sChar[i] = (char)(sChar[i] + 1);
                        }
                    }
                }
            }

            return new string(sChar);
        }
    }
}
