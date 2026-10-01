/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;

        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node n = new Node(node.val);
        dict.Add(node, n);

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0) {
            Node old = queue.Dequeue();
            foreach (Node neighbor in old.neighbors) {
                if (!dict.ContainsKey(neighbor)) {
                    Node nbClone = new Node(neighbor.val);
                    dict[neighbor] = nbClone;
                    queue.Enqueue(neighbor);
                }
                dict[old].neighbors.Add(dict[neighbor]);
            }
        }
        return n;
    }
}