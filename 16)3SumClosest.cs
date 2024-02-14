public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closestAnswer = nums[0]+nums[1]+nums[2];
        for (int i = 0; i < nums.Length - 2; i++) {
            if (i == 0 || nums[i] != nums[i - 1]) {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right) {
                    int sum = nums[i] + nums[left] + nums[right];
                    
                    if (Math.Abs(target-sum)<Math.Abs(target-closestAnswer)) {
                        closestAnswer = sum;     
                    }
                    if(sum>target){
                        right--;
                    }
                    else if(sum<target){
                        left++;
                    }
                    else{
                        return closestAnswer;
                    }

                }
            }
        }
        
        return closestAnswer;
    }
}