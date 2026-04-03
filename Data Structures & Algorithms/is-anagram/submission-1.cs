public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        int[] count = new int[26];
        for(int i=0; i <s.Length; i++){
            int idx1 = s[i] - 'a';
            int idx2 = t[i] - 'a';
            count[idx1]++;
            count[idx2]--;
        }
        foreach(int val in count){
            if(val!=0){
                return false;
            }
        }
        return true;
    }
}
