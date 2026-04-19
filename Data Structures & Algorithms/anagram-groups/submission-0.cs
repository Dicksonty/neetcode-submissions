public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups= new Dictionary<string, List<string>>();
        
        foreach(string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            if(groups.ContainsKey(key))
            {
                groups[key].Add(word);
            }
            else
            {
                List<string> newList = new List<string>();
                newList.Add(word);
                groups[key] = newList;
            }
        }
        return new List<List<string>>(groups.Values);
    }
}
