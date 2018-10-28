using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t001_Add2digits
{
    class Add2digits
    {
        static void Main(string[] args)
        {

            int num = 23;
            int sum = Add2Digits(num);
            Console.WriteLine($"sum is : {sum}");
        }

        static int Add2Digits(int num)
        {
            return num % 10 + num / 10;
        }


    }
}
