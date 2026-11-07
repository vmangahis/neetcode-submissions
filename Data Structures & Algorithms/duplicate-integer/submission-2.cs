public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        foreach(int a in nums){
            if(!hs.Add(a)){
                return true;
            }
            hs.Add(a);
        }
        return false;
    }
}