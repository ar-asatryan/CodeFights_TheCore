using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t004_SeatsInTheater
{
    class SeatsInTheater
    {
        static void Main(string[] args)
        {

            int seats = CountSeatsInTheater(16, 11, 5, 3);

            Console.ReadLine();
        }

        static int CountSeatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nRows - row) * (nCols - (col - 1));
        }

    }
}
