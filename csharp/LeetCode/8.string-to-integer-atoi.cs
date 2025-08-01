/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start

public partial class Solution
{
    public int MyAtoi(string s)
    {
        Dictionary<char, bool> signMap = new()
        {
            { '-', true },
            { '+', false }
        };
        
        if (string.IsNullOrWhiteSpace(s)) return 0;

        s = s.Trim();

        if (signMap.TryGetValue(s.FirstOrDefault(), out var isNegative)) s = s[1..];

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
