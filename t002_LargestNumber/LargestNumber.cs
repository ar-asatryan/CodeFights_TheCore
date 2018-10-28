using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t002_LargestNumber
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            int largestNum = LargestNum(4); 
        }

        static int LargestNum(int n)
        {
            double res = Math.Pow(10, n) - 1;
            int result = (int)res;

            return result;
        }

    }
}
