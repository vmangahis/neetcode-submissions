public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> encounter  = new HashSet<int>();
        foreach(int a in nums){
            if(!encounter.Add(a)){
                return true;
            }

        }
        return false;
    }
}