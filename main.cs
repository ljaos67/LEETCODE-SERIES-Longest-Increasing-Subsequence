/*
time: O(nlogn)
space: O(n)
*/
public class Solution {
    public int LengthOfLIS(int[] nums) 
    {
        if(nums.Length == 0) return 0;
        List<int> dp = new List<int>();

        foreach(var num in nums)
        {
            int left = 0;
            int right = dp.Count;
            while(left < right)
            {
                int mid = left + (right - left)/2;
                if(dp[mid] < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if(left >= dp.Count)
            {
                dp.Add(num);
            }
            else
            {
                dp[left] = num;
            }
        }
        return dp.Count;
    }
}
