public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        if(s.Trim().Length != t.Trim().Length) return false;
        foreach(char a in s.Trim().ToLower()){
            if(!frequency.ContainsKey(a)){
                frequency[a] = 1;
            }
            else{
                frequency[a]++;
            }
        }
        foreach(char b in t.ToLower().Trim()){
            if(!frequency.ContainsKey(b)) return false;
            frequency[b]--;
            if(frequency[b] < 0) return false;
            
        }
        return true;
    }
}
