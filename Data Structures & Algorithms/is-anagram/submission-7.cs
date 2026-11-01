public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Trim().Length != t.Trim().Length) return false;
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach(char a in s){
            if(!freq.ContainsKey(a)){
                freq[a] = 1;
            }
            else{
                freq[a]++;
            }
        }
        foreach(char b in t){
            if(!freq.ContainsKey(b)) return false;
            freq[b]--;
            if(freq[b] < 0) return false;          
            
            
        }
        return true;
    }
}
