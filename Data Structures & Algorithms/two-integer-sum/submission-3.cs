public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int, int>();

        for (int i=0; i < nums.Length; i++)
        {
            int search = target - nums[i];
            if (map.ContainsKey(search))
            {
                return new int[2] {map[search], i};
            }
            else
            {
                map.Add(nums[i], i);
            }
        }

        return new int[2] {0,0};
    }
}
