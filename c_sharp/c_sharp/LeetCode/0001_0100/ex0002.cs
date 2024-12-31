using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.LeetCode._0001_0100
{
    internal class ex0002
    {
        public bool IsPalindrome(int x)
        {
            string temp = new string(x.ToString().Reverse().ToArray());
            return x.ToString() == temp;
        }

        public bool IsPalindrome2(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string temp = x.ToString();
            for (int i = 0; i < temp.Length / 2; i++)
            {
                if (temp[i] != temp[temp.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
