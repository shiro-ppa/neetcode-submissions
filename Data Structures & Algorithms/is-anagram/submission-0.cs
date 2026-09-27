public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (char c in s) {
            letters.TryGetValue(c, out int current);
            letters[c] = current + 1;
        }
        foreach (char c in t) {
            if (!letters.ContainsKey(c)) return false;
            letters[c]--;
            if (letters[c] == 0) letters.Remove(c);
        }        
        return letters.Count == 0;
    }
}
