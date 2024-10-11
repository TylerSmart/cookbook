namespace LeetCode.ZigzagConversion
{
    public static class Solution
    {
        public static string Solve(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1) return s;

            string[] solution = new string[numRows];

            int verticalLength = numRows;
            int diagonalLength = numRows - 2;
            int zigzagLength = diagonalLength + verticalLength;

            int columns = (int)Math.Ceiling(s.Length / (double)(numRows + diagonalLength));

            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < verticalLength; row++)
                {
                    int index = column * zigzagLength + row;

                    if (index < s.Length) solution[row] += (s[index]);

                }

                for (int i = 0; i < diagonalLength; i++)
                {
                    int index = (column * zigzagLength) + verticalLength + i;
                    if (index < s.Length) solution[verticalLength - 1 - (i + 1)] += s[index];

                }
            }

            return string.Concat(solution);
        }
    }
}
