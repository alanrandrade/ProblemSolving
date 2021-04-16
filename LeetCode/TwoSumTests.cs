[TestFixture]
public class TwoSumTests
{
    [TestCase(new int[]{2,7,11,15}, 9, new int[]{0,1})]
    public void GetIndicesForTwoNumbersWhichAddToTarget(int[] numbers, int target, int[] expectedIndices)
    {
        TwoSum twoSum = new TwoSum();
        int[] actualIndices = twoSum.GetIndicesForTwoNumbersWhichAddToTarget(numbers, target);
        Assert.IsTrue(actualIndices.StructuralEquals(expectedIndices), $"Expected '{expectedIndices}' but received '{actualIndices}'");
    }
}