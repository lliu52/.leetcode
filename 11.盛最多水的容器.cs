/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right) {
            max = Math.Max(max, Math.Min(height[left], height[right])*(right-left));
            if(height[left] < height[right]) {
                left++;
            }else{
                right--;
            }
        }
        return max;
       

    }
}
// @lc code=end

