using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_hw1
{
    public void Main()
    {
       public class Solution
    {
        public int[] TwoSum_1(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[2];
        }
        public int[] TwoSum_2(int[] numbers, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(int i in numbers)
            {
                dict.Add(numbers[i], i);
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if (dict.ContainsKey(target - numbers[i]))
                {
                    return new int[2] { i, dict[target - numbers[i]};
                }
            }
            return new int[2];
        }
        public List<List<int>> ThreeSum(int[] numbers)
        {
            if(numbers.Length<3) return new List<List<int>>();
            Array.Sort(numbers);
            List<List<int>> ans = new List<List<int>>();
            //using two pointer method
            for(int i = 0; i < numbers.Length - 2; i++)
            {
                int lf = 1 + i;
                int rt = numbers.Length - 1;
                if (numbers[i] > 0 || (numbers[i] == numbers[i - 1] && i > 0)) continue;
                while (lf < rt)
                {
                    if (numbers[i] + numbers[lf] + numbers[rt] == 0)
                    {
                        List<int> tempans = new List<int>{ numbers[i],numbers[lf],numbers[rt]};
                        ans.Add(tempans);
                        lf++;
                        rt--;
                    }else if (numbers[i] + numbers[lf] + numbers[rt] < 0)
                    {
                        lf++;
                    }
                    else
                    {
                        rt--;
                    }
                }
            }
            return ans;

        }

    }
    
}
