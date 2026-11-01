public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> collection = new HashSet<int>();
        foreach(int a in nums){
            if(!collection.Add(a)){
                return true;
            }
            collection.Add(a);
        }
        return false;
    }
}