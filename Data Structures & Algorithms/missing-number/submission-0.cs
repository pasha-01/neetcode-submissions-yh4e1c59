public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = nums.Length;

        for (int i = 0; i < nums.Length; i++) {
            xor ^= i;        // XOR index
            xor ^= nums[i];  // XOR value
        }

        return xor;
    }
}
