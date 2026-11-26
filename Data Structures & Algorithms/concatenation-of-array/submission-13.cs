public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] answer = new int[nums.Length * 2];
        for(int a=0; a < nums.Length; a++){
            // chain assignment
            answer[a] = answer[a + nums.Length] = nums[a];
        }
        return answer;
    }
}