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
        
        ListNode newList = new ListNode(0);
        ListNode curr = newList;

        while(list1 != null && list2 != null){

            if(list1.val >= list2.val){

                curr.next = list2;
                list2 = list2.next;

            }else{
                curr.next = list1;
                list1 = list1.next;
            }

            curr = curr.next;
        }

        curr.next = list1 ?? list2;

        return newList.next;
    }
}