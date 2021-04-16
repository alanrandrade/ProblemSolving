using NUnit.Framework;
using ProblemSolving.Exceptions;
using System.Linq;

[TestFixture]
public class TwoSumTests
{
    [TestCase(new int[]{2, 7, 11, 15}, 9, new int[]{0,1})]
    [TestCase(new int[]{3, 2, 4}, 6, new int[]{1,2})]
    [TestCase(new int[]{3,3}, 6, new int[]{0,1})]
    public void GetIndicesForTwoNumbersWhichAddToTarget_ValidInputs(int[] numbers, int target, int[] expectedIndices)
    {
        TwoSum twoSum = new TwoSum();
        int[] actualIndices = twoSum.GetIndicesForTwoNumbersWhichAddToTarget(numbers, target);
        Assert.IsTrue(actualIndices.SequenceEqual(expectedIndices), $"Expected '{expectedIndices}' but received '{actualIndices}'");
    }

    [TestCase(new int[] { 2, 7, 11, 15 }, 30, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 20, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 }, 10, new int[] { 0, 1 })]
    public void GetIndicesForTwoNumbersWhichAddToTarget_InvalidInputs(int[] numbers, int target, int[] expectedIndices)
    {
        TwoSum twoSum = new TwoSum();
        Assert.That(() => twoSum.GetIndicesForTwoNumbersWhichAddToTarget(numbers, target), Throws.Exception.TypeOf<SolutionNotFoundException>());
    }
}