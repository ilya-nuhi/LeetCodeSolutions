/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode iter = dummy;
        ListNode temp = dummy;
        // Move iter n+1 steps forward
        for(int i = 0; i <= n ; i++){
            iter = iter.next;
        }
        // Move both pointers until iter reaches the end
        while(iter != null){
            iter = iter.next;
            temp = temp.next;
        }
        // Remove the nth node from the end
        temp.next = temp.next.next;
        return dummy.next; // Return the head of the list
    }
}

// Recursive Approach

/*
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode node, int n)
    {
        return RemoveNthFromEndHelper(node, ref n);
    }

    public ListNode RemoveNthFromEndHelper(ListNode node, ref int n)
    {
        if (node is null)
        {
            return null;
        }

        node.next = RemoveNthFromEndHelper(node.next, ref n);
        n--;

        if (n == 0)
        {
            return node.next;
        }

        return node;
    }
}
*/