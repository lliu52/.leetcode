/*
 * @lc app=leetcode.cn id=16 lang=csharp
 *
 * [16] 最接近的三数之和
 */

// @lc code=start
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int result = Int32.MaxValue;
        for(int i=0; i<nums.Length-2; i++){
            int left = i+1;
            int right = nums.Length-1;
            while(left < right){

            if(Math.Abs(nums[i]+nums[left]+nums[right]-target)<Math.Abs(target-result)){
                result = nums[i]+nums[left]+nums[right];
            }
            if((nums[i]+nums[left]+nums[right]) == target){
                return (nums[i]+nums[left]+nums[right]);
            }else if((nums[i]+nums[left]+nums[right]) > target){
                right--;
            }else {
                left++;
            }

            }
        }
        return result;

    }
}
// @lc code=end

