/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i< nums.Length; i++) {
            if(result.ContainsKey(target - nums[i])) {
                return new int[]{i, result[target-nums[i]]};
            }
            result.TryAdd(nums[i], i);
        }
        return null;

    }
}
// @lc code=end

