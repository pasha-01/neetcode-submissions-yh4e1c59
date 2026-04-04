public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Step 1: Frequency map
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }

        // Step 2: Bucket array
        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (var pair in freq) {
            int count = pair.Value;
            if (bucket[count] == null)
                bucket[count] = new List<int>();
            bucket[count].Add(pair.Key);
        }

        // Step 3: Collect top k
        List<int> result = new List<int>();

        for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--) {
            if (bucket[i] != null) {
                result.AddRange(bucket[i]);
            }
        }

        return result.Take(k).ToArray();
    }
}