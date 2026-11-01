public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> encountered = new Dictionary<int,int>();
        int complement = 0;
        for(int a=0; a<nums.Length; a++){
            complement = target - nums[a];
            if(encountered.ContainsKey(complement)){
                return new int[]{ encountered[complement],a};
            }
            encountered[nums[a]] = a;
        }
        return [];
    }
}
