public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        Array.Fill(prefix, 1);
        Array.Fill(suffix, 1);
        for (int i = 0; i < nums.Length - 1; i++) prefix[i+1] = prefix[i] * nums[i];
        for (int i = nums.Length - 1; i > 0; i--) suffix[i-1] = suffix[i] * nums[i];
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) result[i] = prefix[i] * suffix[i];
        return result;
    }
}
