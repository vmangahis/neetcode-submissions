public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroup  = new Dictionary<string, List<string>>();
        foreach(string a in strs){
            int[] asciiChar = new int[26];
            foreach(char b in a){
                asciiChar[b - 'a']++; // personal notes: this will represent the ascii chars [0,0,0,0,0,1.....] that will be used as a key
            }

            // personal note: will then proceed to turn that array into string
            string k = string.Join(",", asciiChar);

            //personal note: will now check if that string composed exist in the dictionary
            if(!anagramGroup.ContainsKey(k)){
                // personal note: if that long key doesn't exist [0,0,0,0..........] initialize new list
                anagramGroup[k] = new List<string>(); 
            }
     
                // personal note:add after either initializing the list or not
                anagramGroup[k].Add(a);
            


        }
        return anagramGroup.Values.ToList<List<string>>();
    }
}
