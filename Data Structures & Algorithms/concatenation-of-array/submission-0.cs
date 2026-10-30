public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length*2];
        int newArrayCounter = 0;
        for(int a=0; a<ans.Length;a++){
            if(newArrayCounter == nums.Length){
                newArrayCounter = 0;
            }
            ans[a] = nums[newArrayCounter];
            newArrayCounter++;
        }
        return ans;
    }
}