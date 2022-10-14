
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
    public static void Main()
    {
        Solution solution = new Solution();
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode head2= new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
        ListNode head3 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7)))))));

        solution.ReorderList( head);
        solution.ReorderList(head2);
        solution.ReorderList(head3);

        while (head != null)
        {
            Console.Write(head.val+ " ");
            head = head.next;
        }
        Console.WriteLine();
        while (head2 != null)
        {
            Console.Write(head2.val + " ");
            head2 = head2.next;
        }
        Console.WriteLine();

        while (head3 != null)
        {
            Console.Write(head3.val + " ");
            head3 = head3.next;
        }
        Console.ReadLine();
     
    }
}