public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> see = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (see.Contains(nums[i])) {
                return true;
            }
            see.Add(nums[i]);
        }
        return false;
    }
}