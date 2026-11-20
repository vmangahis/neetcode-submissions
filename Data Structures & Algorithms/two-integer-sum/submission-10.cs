public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> complementEncounter = new Dictionary<int,int>();
        int complement;
        for(int a=0; a<nums.Length; a++){
            complement = target - nums[a];
            if(complementEncounter.ContainsKey(complement)){
                return new int []{complementEncounter[complement], a};
            }
            complementEncounter[nums[a]] = a;
        }
        return [];
    }
}
