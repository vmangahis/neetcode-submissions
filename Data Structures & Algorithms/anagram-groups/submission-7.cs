public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var group = new Dictionary<string, List<string>>();
        foreach(string b in strs){
            int[] count = new int[26];
            foreach(char a in b){
                count[a - 'a']++;
             }
            string key = string.Join(",", count);
            if(!group.ContainsKey(key)){
                group[key] = new List<string>();
            }
            group[key].Add(b);

        }
        return group.Values.ToList<List<string>>();


    }
}
