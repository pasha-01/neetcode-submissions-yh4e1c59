public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int , int> map = new Dictionary <int , int>();
        for(int i =0 ; i < nums.Length ; i++){
            int reminder = target- nums[i];
            if ( map.ContainsKey(reminder)){
                return new int[] 
                {
                    map[reminder], i
                };
            }
            map[nums[i]] = i;
        }
        return null;

    }
}
