using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t006_CircleOfNumbers
{
    class CirclesOfNums
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CircleOfNumbers(10,0));
        }

        static int CircleOfNumbers(int n, int firstNumber)
        {
            int res = 0;

            if (firstNumber < n / 2)
                res = firstNumber + n / 2;
            if (firstNumber >= n / 2)
                res = firstNumber - n / 2;

            return res;
        }
    }
}
