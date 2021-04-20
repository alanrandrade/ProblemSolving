using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProblemSolving.General.DataStructures;

namespace ProblemSolving.Solutions.LeetCode
{
    public class AddTwoNumbers
    {
        public  ListNode AddTwoNumbersSolution(ListNode l1, ListNode l2)
        {
            int lengthL1 = GetLengthListNode(l1);
            int lengthL2 = GetLengthListNode(l2);
            ListNode result = (new ListNode() { val = 0, next = null });
            ListNode head = result;

            int longerLength;
            int shorterLength;
            ListNode longerList;
            ListNode shorterList;
            if (lengthL1 >= lengthL2)
            {
                longerLength = lengthL1;
                shorterLength = lengthL2;
                longerList = l1;
                shorterList = l2;
            }
            else
            {
                longerLength = lengthL2;
                shorterLength = lengthL1;
                longerList = l2;
                shorterList = l1;
            }
            
            int carryOne = 0;
            for (int i = 0; i <= longerLength; i++)
            {
                if (i == longerLength)
                {
                    if(carryOne == 1) { 
                        result.val = 1;
                        carryOne = 0;
                    }
                    break;
                }
                if (i >= shorterLength)
                {
                    if (longerList.val + carryOne < 10)
                    {
                        result.val = longerList.val+carryOne;
                        carryOne = 0;
                    }
                    else
                    {
                        result.val = (longerList.val+carryOne) %10;
                        carryOne = 1;
                    }
                }
                else
                {

                    if ((longerList.val + shorterList.val + carryOne) < 10) {
                        result.val = (longerList.val + shorterList.val +carryOne) ;
                        carryOne = 0;
                    }
                    else
                    {
                        result.val = (longerList.val + shorterList.val + carryOne) % 10;
                        carryOne = 1;
                    }
                    shorterList = shorterList.next;
                }
                longerList = longerList.next;
                if (i == 0)
                {
                    head = result;
                }
                if (longerList != null || shorterList != null || carryOne == 1) { 
                    result.next = (new ListNode { val = 0, next = null});
                    result = result.next;
                }
            }
            return head;

        }

        private int GetLengthListNode(ListNode ln)
        {
            int count = 0;
            while (ln != null)
            {
                count++;
                ln = ln.next;
            }
            return count;
        }

        
    }
}
