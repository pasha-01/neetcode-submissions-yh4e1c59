public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            // sort characters to form key
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // add to hashmap
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }

            map[key].Add(str);
        }

        // convert dictionary values to result list
        return new List<List<string>>(map.Values);
    }
}