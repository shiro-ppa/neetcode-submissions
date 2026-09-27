public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums) {
            if (dict.ContainsKey(num)) dict[num]++;
            else dict[num] = 1;
        }
        foreach (var (num, freq) in dict) {
            minHeap.Enqueue(num, freq);
            if (minHeap.Count > k) minHeap.Dequeue();
        }
        for (int i = 0; i < k; i++) result[i] = minHeap.Dequeue();
        return result;
    }
}
