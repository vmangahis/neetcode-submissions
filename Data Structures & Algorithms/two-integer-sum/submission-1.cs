public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> encounteredComplement = new Dictionary<int,int>();
        int[] ans = new int[2];
        int complement = 0;
        for(int a=0; a<nums.Length; a++){
            complement = target - nums[a];
            if(encounteredComplement.ContainsKey(complement)){
                ans[0] = encounteredComplement[complement];
                ans[1] = a; 
                return ans;
            }
            encounteredComplement[nums[a]] = a;
        } 
        return null;
    }
}
