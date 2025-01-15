namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/minimize-xor/

    public class MinimizeXOR
    {
        public static int Solve(int num1, int num2)
        {
            // Calculate the number of 1s (set bits) in both numbers.
            int num1popcount = int.PopCount(num1);
            int num2popcount = int.PopCount(num2);

            // If the count of 1s in num1 and num2 is already the same,
            // num1 itself is the optimal result, as XOR with itself is 0.
            if (num1popcount == num2popcount)
            {
                return num1;
            }

            // if 1s in num2 > 1s in num1 -- create number with 1s in corresponding positions, and remaining in least 0 bits
            // We need to add the missing 1s to num1, starting with the least significant 0 bits.
            if (num2popcount > num1popcount)
            {
                int num1copy = num1;
                int onesToAdd = num2popcount - num1popcount;

                // Initialize a mask to operate on individual bits.
                int mask = 1;

                while (onesToAdd > 0)
                {
                    if ((num1copy & 1) == 0)
                    {
                        // Set the bit in num1 using a bitwise OR with the mask.
                        // That way 0 becomes 1, and 1 stays 1.
                        num1 = num1 | mask;
                        --onesToAdd;
                    }

                    // Shift num1copy to the right to inspect the next bit. "Cut" last bit.
                    num1copy = num1copy >> 1;

                    // Shift the mask to the left to operate on the next bit position. 1, 10, 100, 1000
                    mask = mask << 1;
                }
            }
            // if 1s in num2 < 1s in num1 -- create number with 1s in corresponding positions, starting with higher bits
            // We need to remove excess 1s from num1, starting with the least significant 1 bits.
            else if (num2popcount < num1popcount)
            {
                int num1copy = num1;
                int onesToRemove = num1popcount - num2popcount;

                // Initialize a mask to operate on individual bits.
                int mask = 1;

                while (onesToRemove > 0)
                {
                    if ((num1copy & 1) == 1)
                    {
                        // Clear the bit in num1 using a bitwise XOR with the mask.
                        // That way 1 becomes 0, 0 stays 0.
                        num1 = num1 ^ mask;
                        --onesToRemove;
                    }

                    // Shift num1copy to the right to inspect the next bit. "Cut" last bit.
                    num1copy = num1copy >> 1;

                    // Shift the mask to the left to operate on the next bit position. 1, 10, 100, 1000
                    mask = mask << 1;
                }
            }

            return num1;
        }
    }
}
