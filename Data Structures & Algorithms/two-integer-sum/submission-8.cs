public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int complement;
        var dictionary = new Dictionary<int,int>();
        for(int a = 0; a < nums.Length; a++){
            complement = target - nums[a];
            if(dictionary.ContainsKey(complement)){
                return new int[]{dictionary[complement], a};
            }
            dictionary[nums[a]] = a;
        }
        return null;
    }
}
