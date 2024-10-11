using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MedianOfTwoSortedArrays
{
    public static class Solution
    {
        public static double Solve(int[] nums1, int[] nums2)
        {
            int n = nums1.Length + nums2.Length;
            bool isEven = (n % 2) == 0;

            // cycle through the arrays dynamically
            int lastNumber = 0;
            for (int i = 0, j = 0; (i + j) < n;)
            {
                bool isMedian = i + j >= n / 2;

                int? num1 = i >= nums1.Length? null : nums1[i];
                int? num2 = j >= nums2.Length? null : nums2[j];
                if ((num1 != null && num2 != null && num1 <= num2) || (num1 != null && num2 == null))
                {
                    if (isMedian)
                    {
                        if (isEven)
                        {
                            return ((int)num1 + lastNumber) / 2.0;
                        } else
                        {
                            return (int)num1;
                        }
                    }

                    lastNumber = (int)num1;
                    i++;
                } else if ((num1 != null && num2 != null && num1 > num2) || (num1 == null && num2 != null))
                {
                    if (isMedian)
                    {
                        if (isEven)
                        {
                            return ((int)num2 + lastNumber) / 2.0;
                        }
                        else
                        {
                            return (int)num2;
                        }
                    }

                    lastNumber = (int)num2;
                    j++;
                }
            }

            throw new Exception("Failed to find a solution.");
        }
    }
}
