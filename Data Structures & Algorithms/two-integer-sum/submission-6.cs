public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int complement = 0;
        var encounter = new Dictionary<int, int>();
        for(int a=0; a<nums.Length; a++){
            int val = nums[a];
            complement = target - val;
            if(encounter.ContainsKey((complement))){
                return new int[2] {encounter[complement], a};
            }
            encounter[val] = a;
        }
        return null;
    }
}
