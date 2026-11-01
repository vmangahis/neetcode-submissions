public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Trim().Length != t.Trim().Length) return false;
            //start with frequency counter
            Dictionary<char, int> frequencyCounter = new Dictionary<char, int>();
            foreach(char a in s){
                if(!frequencyCounter.ContainsKey(a)){
                    frequencyCounter[a] = 1;
                }
                else{
                    frequencyCounter[a]++;
                }
            }
            foreach(char b in t){
                if(!frequencyCounter.ContainsKey(b)) return false;
                frequencyCounter[b]--;
                if(frequencyCounter[b] < 0) return false;
            }
            return true;
    }
}
