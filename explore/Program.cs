
public class Solution
{
    public static void Main()
    {
        int[] nums=new int[] { 2, 7, 11, 15 };
        var result=TwoSum(nums, 9);
        foreach(int x in result)
        {
            Console.WriteLine(x);
        }
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        List<int> result = new List<int>();
        
        for(int j = nums.Length-1; j > 0; j--)
        {
            for (int i = j-1; i > -1; i--)
            {
                if (nums[j] + nums[i] == target)
                {
                    result.Add(i);
                    result.Add(j);
                }
            }
        }
        
        return result.ToArray();
    }
}
