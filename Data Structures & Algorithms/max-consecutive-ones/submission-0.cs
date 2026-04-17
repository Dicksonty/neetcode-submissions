public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int currentcount = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                currentcount++;
            }
            else
            {
                currentcount = 0;
            }

            if(currentcount > max)
            {
                max = currentcount;
            }
        }
        return max;
    }
}