using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.KidsWithTheGreatestNumberOfCandies
{
    public static class Solution
    {
        public static IList<bool> Solve(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            return candies.Select(kidCandies => kidCandies + extraCandies >= max).ToList();
        }
    }
}
