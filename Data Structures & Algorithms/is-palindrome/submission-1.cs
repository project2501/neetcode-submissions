public class Solution {
    public bool IsPalindrome(string s) {

        List<char> chars = new List<char>();

        foreach (char c in s.ToLower().ToCharArray())
        {
            if ( 
                ( (c >= 48) && (c <= 57)) || 
                ( (c >= 65) && (c <= 90)) ||
                ( (c >= 97) && (c <= 122)) 
            )
            {                
                chars.Add(c);
            }
        }

        
        int len = chars.Count;
        int mid = len / 2;
        int right = len -1;
        int left = 0;
        if (len == 0) return true;

        while (left != right && left <= mid)
        {
            if (chars[left++] != chars[right--])
            {
               return false;
            }
        }

        return true;
    }
}
