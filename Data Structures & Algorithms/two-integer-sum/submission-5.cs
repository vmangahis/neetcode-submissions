public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var encounter = new Dictionary<int, int>();
        int complement = 0;
        for(int a=0; a<nums.Length; a++){
            complement = target - nums[a];
            if(encounter.ContainsKey(complement)){
                return new int[]{encounter[complement], a};
            }
            encounter[nums[a]] = a;
        }
        return [];
    }
}
