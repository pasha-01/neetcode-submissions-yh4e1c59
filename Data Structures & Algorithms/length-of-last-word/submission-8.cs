public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int length = 0;

        // Step 1: skip trailing spaces
        while (i >= 0 && s[i] == ' ') {
            i--;
        }

        // Step 2: count last word
        while (i >= 0 && s[i] != ' ') {
            length++;
            i--;
        }

        return length;
    }
}