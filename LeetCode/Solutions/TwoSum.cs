public class TwoSum
{

    public int[] GetIndicesForTwoNumbersWhichAddToTarget(int[] numbers, int target)
    {
        for(int index = 0; index < numbers.Length; index++)
        {
            for(int indexRemainder = index+1; indexRemainder < numbers.Length; indexRemainder++)
            {
                if(numbers[index] + numbers[indexRemainder] == target)
                {
                    return new int[]{index, indexRemainder};
                }
            }
        }
    }
    
}