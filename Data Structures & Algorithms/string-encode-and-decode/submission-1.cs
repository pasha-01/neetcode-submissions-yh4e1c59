public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach (string s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;

            // find the separator '#'
            while (s[j] != '#') {
                j++;
            }

            // extract length
            int length = int.Parse(s.Substring(i, j - i));

            // move past '#'
            j++;

            // extract the string
            string str = s.Substring(j, length);
            result.Add(str);

            // move pointer forward
            i = j + length;
        }

        return result;
    }
}