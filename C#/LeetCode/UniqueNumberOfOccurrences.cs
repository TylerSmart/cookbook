using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.UniqueNumberOfOccurrences
{
    public static class Solution
    {
        public static bool Solve(int[] arr)
        {
            Dictionary<int, int> numCountDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (numCountDict.ContainsKey(arr[i]) == false) numCountDict.Add(arr[i], 0);
                numCountDict[arr[i]]++;
            }

            HashSet<int> counts = new HashSet<int>();

            foreach (int count in numCountDict.Values)
            {
                if (counts.Contains(count))
                {
                    return false;
                } else
                {
                    counts.Add(count);
                }
            }

            return true;
        }
    }
}
