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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode myList = null;
        return MergeTwoListsHelper(myList, list1, list2);
    }

    public ListNode MergeTwoListsHelper(ListNode mylist, ListNode list1, ListNode list2){
        if(mylist==null && (list1!=null || list2!=null)) mylist = new ListNode();
        if(list1!=null && list2!=null){
            if(list1.val < list2.val){
                mylist.val = list1.val;
                list1=list1.next;
            }
            else{
                mylist.val = list2.val;
                list2=list2.next;
            }
               
        }
        else if(list1!=null){
            mylist.val = list1.val;
            list1=list1.next;
        }
        else if(list2!=null){
            mylist.val = list2.val;
            list2=list2.next;
        }
        else{
            return mylist;
        }

        mylist.next = MergeTwoListsHelper(mylist.next, list1, list2);

        return mylist;

    }

}