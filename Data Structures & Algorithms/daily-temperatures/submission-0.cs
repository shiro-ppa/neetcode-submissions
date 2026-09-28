public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] days = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++) {
            if (stack.Count == 0) stack.Push(i);
            while (stack.Count != 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int prev = stack.Pop();
                days[prev] = i - prev;
            }
            stack.Push(i);
        }
        return days;
    }
}
