public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> seen = new Dictionary<int,bool>();
        for(int i =0; i<nums.Length; i++){
            int num = nums[i];
            bool alreadySeen=false;
            foreach(var key in seen.Keys){
                if(key==num){
                    alreadySeen=true;
                    break;
                }
            }
            if(alreadySeen){
                return true;
            }
            seen[num]= true;
        }
        return false;
    }
}