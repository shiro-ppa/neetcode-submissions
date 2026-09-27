public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            hash.Add(nums[i]);
        }

        if (hash.Count == 0) return 0;

        int start = 0;
        int count = 1;
        int longest = count;
        foreach (int num in hash) {
            if (!hash.Contains(num - 1)) {
                start = num;
                for (int j = 0; j < nums.Length; j++) {
                    if (hash.Contains(start + count)) count++;
                    else {
                        count = 0;
                        break;
                    }
                    longest = Math.Max(longest, count);
                }   
            }
        }

        return longest;
    }
}
