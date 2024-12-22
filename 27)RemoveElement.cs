public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        foreach(var num in nums){
            if(num!=val){
                nums[k] = num;
                k++;
            }
        }
        return k;
    }
}