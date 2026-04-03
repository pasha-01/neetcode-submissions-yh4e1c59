
//   Definition for singly-linked list.
//   public class ListNode {
//       public int val;
//       public ListNode next;
//       public ListNode(int val=0, ListNode next=null) {
//           this.val = val;
//           this.next = next;
//       }
//   }
 

// public class Solution {
//     public bool HasCycle(ListNode head) {
//         if(head == null){
//             return false;
//         }
//         ListNode slow = head;
//         ListNode fast = head.next;
//         while(slow !=null || fast!=null){
//             if(fast.next==null){
//                 return false;
//             }
//             if(fast == slow){
//                 return true;
//             }
//             slow=slow.next;
//             fast=fast.next.next;
//         }
//         return false;
//     }
// }

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;          // 1 step
            fast = fast.next.next;     // 2 steps

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}
