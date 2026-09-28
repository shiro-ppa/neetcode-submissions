public class Solution {
    public int CalPoints(string[] operations) {
        int sum = 0;
        Stack<int> stack = new Stack<int>();

        foreach (string op in operations) {
            if (op == "+") {
                int temp = stack.Pop();
                int score = temp + stack.Peek();
                stack.Push(temp);
                stack.Push(score);
                sum += score;
            }
            else if (op == "C") {
                sum -= stack.Pop();
            }
                
            else if (op == "D") {
                stack.Push(stack.Peek() * 2);
                sum += stack.Peek();
            }
            
            else {
                stack.Push(int.Parse(op));
                sum += stack.Peek();
            }
        }
        return sum;
    }
}