using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.LeetCode._001_050
{
    public class _001_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return new int[] { dic[nums[i]], i };
                else
                    dic[target - nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
