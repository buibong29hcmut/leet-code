
  public class ListNode 
{
    public int val;
    public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
        this.val = val;
       this.next = next;
     }
  }

public class Solution
{
    public void ReorderList( ListNode head)
    {
        ListNode clone = head;
        List<int> queue = new List<int>();
        while (clone != null)
        {
             queue.Add(clone.val); 
             clone = clone.next;
        }
        ListNode clone2 = head;
      
        for(int i= queue.Count-1; i>=(queue.Count)/2; i--)
        {
            ListNode node = new ListNode(queue[i]);
            ListNode nodeNext = clone2.next;
            node.next = clone2.next;
            clone2.next = node;
            clone2 = nodeNext;
        }
        ListNode clone3 = head;
        for (int i=0;i<= queue.Count-2; i++)
        {
            clone3 = clone3.next;
        }
        clone3.next = null;
     
    }
  
}