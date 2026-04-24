public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> maps = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(maps.ContainsKey(complement))
            {
                return new int[] {maps[complement], i};
            }
           maps[nums[i]] = i;
        }

        return new int[0];

    }
}
