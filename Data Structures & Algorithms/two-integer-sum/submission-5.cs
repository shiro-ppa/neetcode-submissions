public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++){
            var c = target - nums[i];
            if (dict.ContainsKey(c)) return new int[]{dict[c], i};
            dict[nums[i]] = i;
        }        
        return new int[]{-1, -1};
    }
}
