using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t008_PhoneCall
{
    class PhoneCall
    {
        static void Main(string[] args)
        {
            int minutes = MinutesPhoneCall(3,1,2,20);
            Console.WriteLine(minutes);
        }

        static int MinutesPhoneCall(int min1, int min2_10, int min11, int s)
        {

            int minutes = 0;
            int cost9 = min2_10 * 9;
            int cost10 = min1 + cost9;

            if (s < cost10)
            {
                if (s == min1)
                    minutes = 1;
                minutes = 1 + (s - min1) / min2_10;
            }
            else if (s == cost10)
            {
                minutes = 10;

            }
            else if (s > cost10)
            {
                minutes = 10 + (s - cost10) / min11;
            }

            return minutes;
        }

    }
}
