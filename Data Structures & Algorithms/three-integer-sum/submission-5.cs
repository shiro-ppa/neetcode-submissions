public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> mainList = new List<List<int>>();

        int target = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;
            int j = i+1;
            int k = nums.Length-1;
            target = -nums[i];
            while (j < k) {
                if (nums[j] + nums[k] < target) j++;
                else if (nums[j] + nums[k] > target) k--;
                else {
                    var list = new List<int>{nums[i], nums[j], nums[k]};
                    mainList.Add(list);

                    j++;
                    while (j < k && nums[j] == nums[j-1]) j++;
                    k--;
                    while (j < k && nums[k] == nums[k+1]) k--;
                }
            }
        }

        return mainList;
    }
}
