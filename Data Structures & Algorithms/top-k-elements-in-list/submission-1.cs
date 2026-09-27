public class Solution {

    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));

        foreach (int num in nums) {
            if (dict.ContainsKey(num)) dict[num]++;
            else dict[num] = 1;
        }
        foreach (var (num, freq) in dict) {
            maxHeap.Enqueue(num, freq);
        }
        for (int i = 0; i < k; i++) result[i] = maxHeap.Dequeue();
        return result;
    }
}
