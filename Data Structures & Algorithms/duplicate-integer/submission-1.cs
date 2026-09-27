public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (seen.ContainsKey(nums[i])) return true;
            seen.Add(nums[i], 1);
        }
        return false;
    }
}