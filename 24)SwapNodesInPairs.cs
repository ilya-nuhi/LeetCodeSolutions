public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode prev = new();
        var a = head;
        var b = head?.next;

        head = b ?? a;

        while (a != null && b != null)
        {
            (prev.next, a.next, b.next) = (b, b.next, a); //swap the nodes
            (prev, a, b) = (a, a.next, a.next?.next); //move on
        }

        return head;
    }
}