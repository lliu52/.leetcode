/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        int[] left_max = new int[height.Length];
        left_max[0] = 0;
        int[] right_max = new int[height.Length];
        right_max[height.Length-1] = 0;
        for(int i = 1; i < height.Length; i++){
            left_max[i] = Math.Max(height[i-1], left_max[i-1]);
        }
        for(int i = height.Length-2; i>=0; i--) {
            right_max[i] = Math.Max(height[(i+1)], right_max[i+1]);
        }
        int result = 0;
        for (int i =0; i<height.Length; i++){
            result += (Math.Min(left_max[i], right_max[i])-height[i]) >0? (Math.Min(left_max[i], right_max[i])-height[i]): 0;
        }
        return result;

    }
}
// @lc code=end

