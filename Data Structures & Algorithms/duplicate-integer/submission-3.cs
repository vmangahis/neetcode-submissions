public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();
        foreach(int a in nums){
            if(!dup.Add(a)){
                return true;
            }
            dup.Add(a);
        }
        return false;
    }
}