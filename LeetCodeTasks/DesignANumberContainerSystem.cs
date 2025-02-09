using System;
using System.Collections.Generic;

namespace LeetCodeTasks
{
    // Link: https://leetcode.com/problems/design-a-number-container-system/

    public class DesignANumberContainerSystem
    {
        private Dictionary<int, int> _byIndex;
        private Dictionary<int, LinkedList<int>> _byNumber;

        public DesignANumberContainerSystem()
        {
            _byIndex = new Dictionary<int, int>();
            _byNumber = new Dictionary<int, LinkedList<int>>();
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
            if (!_byNumber.TryGetValue(number, out LinkedList<int> indexes))
            {
                LinkedList<int> numberIndexes = new LinkedList<int>();
                numberIndexes.AddLast(index);
                _byNumber[number] = numberIndexes;

                // -1 means NOT SORTED
                numberIndexes.AddFirst(-1);
            }
            else
            {
                _byNumber[number].AddLast(index);

                // -1 means NOT SORTED
                _byNumber[number].First.Value = -1;
            }
        }

        public int Find(int number)
        {
            if (_byNumber.TryGetValue(number, out LinkedList<int> indexes))
            {
                if (indexes.Count <= 1)
                {
                    return -1;
                }
                else
                {
                    if (_byNumber[number].First.Value == -1)
                    {
                        int[] iArray = new int[indexes.Count];
                        indexes.CopyTo(iArray, 0);
                        Array.Sort(iArray);
                        indexes = new LinkedList<int>(iArray);

                        // -2 means SORTED
                        indexes.First.Value = -2;

                        _byNumber[number] = indexes;
                    }

                    return indexes.First.Next.Value;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
