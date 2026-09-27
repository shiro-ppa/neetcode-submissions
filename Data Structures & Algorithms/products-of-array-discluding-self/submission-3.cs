public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        ans[0] = 1;
        for (int i = 0; i < nums.Length - 1; i++) ans[i+1] = ans[i] * nums[i];
        int suffixProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            ans[i] = ans[i] * suffixProduct; 
            suffixProduct *= nums[i];
        }
        return ans;
    }
}
