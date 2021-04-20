using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.General
{
    public static class DataStructures
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public static ListNode ToListNode(int[] listIntegers)
            {
                ListNode current = new ListNode();
                ListNode head = new ListNode();
                for(int i= 0; i < listIntegers.Length; i++)
                {
                    current.val = listIntegers[i];
                    if (i == 0)
                    {
                        head = current;
                    }
                    if (i != listIntegers.Length - 1)
                    {
                        current.next = new ListNode() { val = 0, next = null};
                        current = current.next;
                    }
                    else
                    {
                        current.next = null;
                    }
                }
                return head;
            }
        };

    }
}
