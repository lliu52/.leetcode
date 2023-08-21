/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if(x <0){
            return false;
        }
        int temp = x;
        int reverse = 0;
        while(x > 0){
            reverse = reverse * 10 + x%10;
            x = x / 10;
        }
        Console.WriteLine(reverse);
        if(reverse == temp){
            Console.WriteLine("111");
            return true;
        }else{
            Console.WriteLine("222");
            return false;
        }
        
    }
}
// @lc code=end

