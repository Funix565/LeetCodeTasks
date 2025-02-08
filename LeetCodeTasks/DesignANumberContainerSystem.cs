using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/design-a-number-container-system/

    public class DesignANumberContainerSystem
    {
        private Dictionary<int, int> _byIndex;
        private Dictionary<int, SortedList<int, int>> _byNumber;

        public DesignANumberContainerSystem()
        {
            _byIndex = new Dictionary<int, int>();
            _byNumber = new Dictionary<int, SortedList<int, int>>();
        }

        public void Change(int index, int number)
        {
            // save previous number
            int previousNumber;
            if (_byIndex.TryGetValue(index, out int value))
            {
                previousNumber = value;

                // remove index for previous number
                _byNumber[previousNumber].Remove(index);
            }

            // change
            _byIndex[index] = number;

            // maintain indexes for number
            if (!_byNumber.TryGetValue(number, out SortedList<int, int> indexes))
            {
                SortedList<int, int> numberIndexes = new SortedList<int, int>();
                numberIndexes.Add(index, index);
                _byNumber[number] = numberIndexes;
            }
            else
            {
                _byNumber[number].Add(index, index);
            }
        }

        public int Find(int number)
        {
            if (_byNumber.TryGetValue(number, out SortedList<int, int> sortedIndexes))
            {
                if (sortedIndexes.Keys.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return sortedIndexes.Keys[0];
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
