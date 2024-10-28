using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindTheDifferenceOfTwoArrays
{
    public static class Solution
    {
        public static IList<IList<int>> Solve(int[] nums1, int[] nums2)
        {
            List<List<int>> output = new List<List<int>>() { new(), new() };

            Dictionary<int, int> numDict = new();
            
            for (int i = 0; i < nums1.Count(); i++)
            {
                if (numDict.ContainsKey(nums1[i]) == false) numDict.Add(nums1[i], 0);
            }

            for (int i = 0; i < nums2.Count(); i++)
            {
                if (numDict.ContainsKey(nums2[i]) == false)
                {
                    numDict.Add(nums2[i], 1);
                } else if (numDict[nums2[i]] == 0)
                {
                    numDict[nums2[i]] = -1;
                }
            }

            numDict.Keys.ToList().ForEach(num =>
            {
                if (numDict[num] == -1) return;
                output[numDict[num]].Add(num);
            });

            return output.Select(innerList => (IList<int>)innerList).ToList();
        }
    }
}
