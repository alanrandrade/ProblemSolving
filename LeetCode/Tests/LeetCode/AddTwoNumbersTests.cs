using NUnit.Framework;
using ProblemSolving.Exceptions;
using ProblemSolving.General;
using ProblemSolving.Solutions.LeetCode;
using System.Linq;
using static ProblemSolving.General.DataStructures;

[TestFixture]
public class AddTwoNumbersTests
{
    [TestCase(new int[]{9, 9, 1}, new int[] { 1 }, new int[]{0,0,2})]
    [TestCase(new int[]{2, 4, 3}, new int[] { 5, 6, 4 }, new int[]{7,0,8})]
    [TestCase(new int[]{2, 4, 9}, new int[] { 5, 6, 4, 9 }, new int[]{7,0,4,0,1})]
    [TestCase(new int[]{0}, new int[] { 0 }, new int[]{0})]
    [TestCase(new int[]{ 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[]{ 8, 9, 9, 9, 0, 0, 0, 1 })]
    public unsafe void GetListNodeLenght(int[] l1, int[] l2, int[] expectedResult)
    {
        AddTwoNumbers sol = new AddTwoNumbers();
        ListNode list1 = ListNode.ToListNode(l1);
        ListNode list2 = ListNode.ToListNode(l2);
        ListNode actualResultingList = sol.AddTwoNumbersSolution(list1, list2);
        ListNode expectedResultListNode = ListNode.ToListNode(expectedResult);

        bool areTheSame = true;
        while (expectedResultListNode != null)
        {
            areTheSame &= actualResultingList.val == expectedResultListNode.val;
            actualResultingList = actualResultingList.next;
            expectedResultListNode = expectedResultListNode.next;
        }

        Assert.IsTrue(areTheSame, "Expected resulting list to be the same as actual list.");
    }

    
}