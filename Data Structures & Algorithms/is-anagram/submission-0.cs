public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> maps = new Dictionary<char, int>();
        Dictionary<char, int> mapt = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(maps.ContainsKey(c))
            {
                maps[c]++;
            }
            else
            {
                maps[c] = 1;
            }
        }

        foreach(char y in t)
        {
            if(mapt.ContainsKey(y))
            {
                mapt[y]++;
            }
            else
            {
                mapt[y] = 1;
            }
        }

        if(mapt.Count != maps.Count)
        {
            return false;
        }

        foreach( var pair in maps)
        {
            char key = pair.Key;
            int value = pair.Value;

            if(!mapt.ContainsKey(key))
            {
                return false;
            }

            if(mapt[key] != value)
            {
                return false;
            }

            
        }

        return true;
    }
}
