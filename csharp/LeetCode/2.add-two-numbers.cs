/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

// @lc code=start

public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        static (int, bool) Add(int digit1, int digit2, bool carry)
        {
            var sum = digit1 + digit2;

            if (carry) sum += 1;

            return sum >= 10 ? (sum - 10, true) : (sum, false);
        }

        var (sum, carry) = Add(l1.val, l2.val, false);

        var current = new ListNode(sum, null);
        var head = current;

        l1 = l1.next;
        l2 = l2.next;

        while (l1 != null || l2 != null)
        {
            l1 ??= new(0, null);
            l2 ??= new(0, null);

            (sum, carry) = Add(l1.val, l2.val, carry);

            current.next = new(sum, null);
            
            current = current.next;

            l1 = l1.next;
            l2 = l2.next;
        }

        if (carry) current.next = new(1, null);

        return head;
    }
}
// @lc code=end
