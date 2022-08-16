using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Add_Two_Number
{
    public class ListNode
    {
        public ListNode next;
        public int val;
        public ListNode(int val=0, ListNode next=null)
        {
           this.val = val;
            this.next = next;   
        }
    }
}
