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

    public class DesignANumberContainerSystem_Editorial_SortedSet
    {
        private Dictionary<int, SortedSet<int>> _numberToIndexes;
        private Dictionary<int, int> _indexToNumbers;

        public DesignANumberContainerSystem_Editorial_SortedSet()
        {
            _numberToIndexes = new Dictionary<int, SortedSet<int>>();
            _indexToNumbers = new Dictionary<int, int>();
        }

        public void Change(int index, int number)
        {
            // If index already has a number, remove it from the old number's index set
            if (_indexToNumbers.TryGetValue(index, out int value))
            {
                int oldNumber = value;
                _numberToIndexes[oldNumber].Remove(index);

                if (_numberToIndexes[oldNumber].Count == 0)
                {
                    _numberToIndexes.Remove(oldNumber);
                }
            }

            // Update the number and add the index to the new number's set
            _indexToNumbers[index] = number;

            if (!_numberToIndexes.TryGetValue(number, out SortedSet<int> indexes))
            {
                indexes = new SortedSet<int>();
                _numberToIndexes[number] = indexes;
            }

            _numberToIndexes[number].Add(index);
        }

        public int Find(int number)
        {
            if (_numberToIndexes.TryGetValue(number, out SortedSet<int> value))
            {
                // Get the minimum value in the SortedSet
                return value.Min;
            }
            else
            {
                return -1;
            }
        }

    }

}
