public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var charMap = new Dictionary<char, int>();
        char[] charsS = s.ToCharArray();
        char[] charsT = t.ToCharArray();

        if (charsS.Length != charsT.Length) return false;

        for (int i = 0; i < charsS.Length; i ++)
        {
            char cs = charsS[i];

            if (!charMap.ContainsKey(cs))
            {
                charMap.Add(cs, 1);
            }
            else
            {
                charMap[cs]++;
            }

            char ct = charsT[i];

            if (charMap.ContainsKey(ct))
            {
                charMap[ct]--;
            }
            else
            {
                charMap.Add(ct, -1);
            }
        }

        foreach (var map in charMap)
        {
            if (map.Value != 0) return false;
        }

        return true;
        
    }
}
