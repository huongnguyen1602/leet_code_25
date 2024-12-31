using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.LeetCode._0001_0100
{
    internal class ex0013
    {
        private static Dictionary<char, int> MapValue = new Dictionary<char, int>() {
            { 'I', 1},
            { 'V', 5},
            { 'X', 10},
            { 'L', 50},
            { 'C', 100},
            { 'D', 500},
            { 'M', 1000}
        };
        public int RomanToInt(string s)
        {
            int res = 0;
            char[] chars = s.ToCharArray();
            int length = chars.Length;
            for (int i = 0; i < length; i++)
            {
                //ưu tiên check trường hơp ít hơn
                if (i + 1 < length && MapValue[chars[i]] < MapValue[chars[i + 1]])
                {
                    res = res - MapValue[chars[i]];
                }
                else
                {
                    res = res + MapValue[chars[i]];
                }
            }
            return res;
        }
    }
}
