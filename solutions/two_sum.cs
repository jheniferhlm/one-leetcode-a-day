public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var prevNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (prevNumbers.ContainsKey(complement))
            {
                return [prevNumbers[complement], i];
            }

            prevNumbers.TryAdd(nums[i], i);
        }

        return [];
    }
}