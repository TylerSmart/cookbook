using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.GreatestCommonDivisorOfStrings
{
    public static class Solution
    {
        public static string Solve(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";

            int gcdLength = GCD(str1.Length, str2.Length);

            return str1.Substring(0, gcdLength);
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
