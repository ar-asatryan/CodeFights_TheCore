using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t007_LateRide
{
    class LateRide
    {
        static void Main(string[] args)
        {
            int sumDigs = LateRideCounter(255);
            Console.ReadLine();
        }

        static int LateRideCounter(int n)
        {

            int sum = 0;
            int hour = 60;
            int time1 = n / hour;
            int time2 = n % hour;

            sum = time1 % 10 + time1 / 10 + time2 % 10 + time2 / 10;
            return sum;
        }
    }
}
