using Problem2.Add_Two_Number;

 ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode cloneL1 = l1;
    ListNode cloneL2 = l2;
    ListNode dummyHead = new ListNode(0);
    ListNode current = dummyHead;
    int carry=0;
    while(cloneL1 != null|| cloneL2 != null)
    {
        int x= cloneL1!=null?cloneL1.val:0;
        int y =cloneL2!=null?cloneL2.val:0;
  
        int sum = x + y + carry;
        carry = sum / 10;
        current.next = new ListNode(sum % 10);
        current = current.next;
        if(cloneL2 != null) cloneL2= cloneL2.next;
        if (cloneL1!=null) cloneL1= cloneL1.next;

    }
    if (carry  > 0)
    {
        current.next= new ListNode(carry);
    }
    return dummyHead.next;
}
