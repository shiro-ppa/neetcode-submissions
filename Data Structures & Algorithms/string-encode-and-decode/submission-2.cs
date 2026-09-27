public class Solution {

    public string Encode(IList<string> strs) {
        string encodedStrs = "";
        foreach (string str in strs) {
            encodedStrs += str.Length + "#" + str;
        }

        return encodedStrs;
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        int i = 0;
        int j = 0;
        int length = 0;
        while (i < s.Length) {
            j = i;
            while (s[j] != '#') j++; 
            length = int.Parse(s.Substring(i, j-i));
            list.Add(s.Substring(j+1, length));
            i = j+length+1;
        }
        return list;
   }
}
