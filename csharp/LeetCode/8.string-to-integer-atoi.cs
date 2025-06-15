/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start

using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    private static readonly Dictionary<char, bool> _signMap = new()
    {
        { '-', true },
        { '+', false }
    };

    public int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        s = s.Trim();

        if (_signMap.TryGetValue(s.FirstOrDefault(), out var isNegative)) s = s[1..];

        long result = 0;
        var resultStr = isNegative ? "-" : string.Empty;

        foreach (var c in s)
        {
            if (!char.IsNumber(c)) break;

            resultStr += c;

            result = long.Parse(resultStr);

            if (result < int.MinValue) return int.MinValue;
            if (result > int.MaxValue) return int.MaxValue;
        }

        return (int)result;
    }
}
// @lc code=end
