using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t005_MaxMultiple
{
    class MaxMulty
    {
        static void Main(string[] args)
        {

            int maxMul = MaxMultiple(3, 10);
        }

        static int MaxMultiple(int divisor, int bound)
        {
            int i = 1;
            int maxMul = 1;
            while (maxMul <= bound)
            {
                maxMul = divisor * i;
                i++;
            }
            return maxMul - divisor;
        }
    }
}
