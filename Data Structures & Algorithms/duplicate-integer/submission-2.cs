public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            if (!seen.Add(nums[i])) return true;
        }
        return false;
    }
}