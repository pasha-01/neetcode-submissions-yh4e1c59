public class Solution {
    public int ScoreOfString(string s) {
        int score = 0;
        for(int i = 0;i <s.Length-1 ; i++){
            int diff = s[i] - s[i+1];

            if(diff<0){
                diff= -diff;
            }
            score = score+ diff;
        }
        return score;
    }
}