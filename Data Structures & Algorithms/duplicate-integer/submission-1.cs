public class Solution {
    public bool hasDuplicate(int[] nums) {
       Dictionary<int,int> maps = new Dictionary<int, int>();
       for(int i = 0; i < nums.Length; i++)
       {
            if(maps.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                maps[nums[i]] = 1;
            }
       }
       return false;
    }
}