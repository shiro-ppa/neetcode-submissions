public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++) {
            if (tokens[i] == "+") stack.Push(stack.Pop() + stack.Pop());
            else if (tokens[i] == "-") stack.Push(-(stack.Pop() - stack.Pop()));
            else if (tokens[i] == "*") stack.Push(stack.Pop() * stack.Pop());
            else if (tokens[i] == "/") {
                int top = stack.Pop();
                stack.Push(stack.Pop() / top);
            }
            else stack.Push(int.Parse(tokens[i]));
        }
        return stack.Pop();
    }
}
