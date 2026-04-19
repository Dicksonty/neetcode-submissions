public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!freq.ContainsKey(num))
            {
                freq[num] = 0;
            }
            freq[num]++;
        }

        var list = freq.ToList();
        list.Sort((a,b) => b.Value.CompareTo(a.Value));

        return list.Take(k).Select(x =>x.Key).ToArray();
    }
}
