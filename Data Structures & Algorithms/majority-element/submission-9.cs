public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int mostFrequent = 0;
        foreach(int a in nums){
            if(!frequency.ContainsKey((a))){
                frequency[a] = 1;
                mostFrequent = a;
            }
            else{
                frequency[a]++;
            }
        }
        foreach(int b in nums){
            if(frequency[mostFrequent] < frequency[b]){
                            Console.WriteLine($"{mostFrequent} < {frequency[b]} - {b}");

                mostFrequent = b;
            }
        }
        return mostFrequent;
    }
}