public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] c = str.ToCharArray();
            Array.Sort(c);
            string key = new string(c);

            if (!dict.ContainsKey(key)) dict[key] = new List<string>();
            dict[key].Add(str);
        }

        List<List<string>> list = dict.Values.ToList();
        return list;
    }
}
