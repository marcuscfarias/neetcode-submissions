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
    public bool HasCycle(ListNode head) {
        
        var fastPointer = head?.next;
        var slowPointer = head;

        while(fastPointer != null || fastPointer != slowPointer){

            if(fastPointer == slowPointer)
                return true;

            slowPointer = slowPointer.next;
            fastPointer = fastPointer?.next?.next;
        }

        return false;
    }
}
