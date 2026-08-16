public class Solution {
    public int MaxArea(int[] heights) 
    {
        int left = 0;
        int right = heights.Length - 1;
        int max = 0;

        while (left != right)
        {
            int leftVal = heights[left];
            int rightVal = heights[right];
            int dist = (right - left);

            if (leftVal < rightVal)
            {
                max = Math.Max(max, (leftVal * dist));
                left++;
            }
            else
            {
                max = Math.Max(max, (rightVal * dist));
                right--;
            }            
        }
        
        return max;
    }
}
