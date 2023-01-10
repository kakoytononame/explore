


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

public class Solution
{
    public static void Main()
    {
        ListNode l6=new ListNode(4);
        ListNode l5 = new ListNode(6,l6);
        ListNode l4 = new ListNode(5,l5);
        ListNode l3 = new ListNode(3);
        ListNode l2 = new ListNode(4,l3);
        ListNode l1 = new ListNode(2,l2);
        ListNode l7 = AddTwoNumbers(l1,l4);
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode l3=new ListNode();
        ListNode copy=l3;
        int sum = 0;
        while (l1 != null || l2 != null || sum != 0)
        {
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            ListNode newNode=new ListNode();
            newNode.val = sum % 10;
            copy.next = newNode;
            copy = newNode;
            sum /= 10;
        }
        
        return l3.next;
    }
}