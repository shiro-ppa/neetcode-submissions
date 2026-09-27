public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;

        int left = 0;
        int right = heights.Length - 1;
        int temp = 0;

        while (left < right) {
            if (heights[left] < heights[right]) {
                temp = heights[left] * (right - left);
                left++;
            }
            else {
                temp = heights[right] * (right - left);
                right--;
            }
            if (temp > max) max = temp;
        }
        return max;
    }
}
