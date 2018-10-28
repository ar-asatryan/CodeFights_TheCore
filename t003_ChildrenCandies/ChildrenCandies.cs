using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t003_ChildrenCandies
{
    class ChildrenCandies
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Candies(3,10));
            Console.ReadLine();
        }


        static int Candies(int n, int m)
        {

            int eatedCandies;
            if (m % n == 0)
            {
                eatedCandies = m;
            }
            else
            {
                eatedCandies = m - m % n;
            }


            return eatedCandies;
        }



    }
}
