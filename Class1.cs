using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace antra_cs_hw2
{
    public class hw2_solution
    {
       public int[] Generatenum()
        {
            int upper = 20;
            int rndnum = RandomNumberGenerator.GetInt32(upper);
            int[] ans = new int[rndnum];
            for(int i = 0; i < rndnum; i++)
            {
                ans[i] = i+1;
            }
            return ans;

        }
        public int[] Reversenum(int[] arrs)
        {
            int sz = arrs.Length;
            int[] ans = new int[sz];
            for(int i = 0; i < sz; i++)
            {
                ans[sz - i] = i + 1;
            }
            return ans;
        }
        public void PrintNum(int[] arrs)
        {
            for(int i = 0; i < arrs.Length; i++)
            {
                Console.WriteLine(arrs[i]);
            }
        }
        public int Fibo(int num)
        {
            if (num <= 0) return 0;
            if (num <= 2) return 1;
            int[] ls = new int[num+1];
            ls[0] = 0;
            ls[1] = 1;
            ls[2] = 1;
            for(int i = 3; i < num; i++)
            {
                ls[i] = ls[i - 1] + ls[i - 2];
            }
            return ls[num];
        }
    }
}
