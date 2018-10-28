using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentTask
{
    class CurrentProgram
    {
        static void Main(string[] args)
        {
            int w1 = 5;
            int v1 = 9;
            int w2 = 3;
            int v2 = 7;
            //int maxW = 4;
            var dict = new Dictionary<int, int>
            {
                { w1, v1 },
                { w2, v2 }
            };

            int max = dict[w1];


            int result = knapsackLight(10, 5, 6, 4, 9);
            Console.ReadLine();
        }

        //Codefights The Core Methods starting with t009>>

        static bool reachNextLevel(int experience, int threshold, int reward)
        {

            return experience + reward >= threshold;
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {

            int[] arrWeight = { weight1, weight2 };
            int[] arrValue = { value1, value2 };

            int minInd = 0;
            if (arrWeight.Min() == arrWeight[1])
            {
                minInd = 1;
            }

            if (maxW < arrWeight.Min())
            {
                return 0;
            }
            else if (maxW < arrWeight.Max() && maxW >= arrWeight.Min())
            {
                return arrValue[minInd];
            }
            else if (maxW >= arrWeight.Max() && maxW < weight1 + weight2)
            {
                return arrValue.Max();
            }
            else if (maxW >= weight1 + weight2)
            {
                return value1 + value2;
            }
            

            return 0;
        }


        int extraNumber(int a, int b, int c)
        {
            int[] arr = { a, b, c };

            if (a == b)
                return c;
            if (a == c)
                return b;
            if (b == c)
                return a;
            return 0;
        }


        bool isInfiniteProcess(int a, int b)
        {
            //while(a != b)
            //{
            //    a++;
            //    b--;        
            //}
            if (a == b)
                return false;
            if (b - a > 1 && (b - a) % 2 != 0)
                return true;
            if (b - a <= 1)
            {
                return true;
            }
            return false;
        }


        bool arithmeticExpression(int a, int b, int c)
        {


            if (a + b == c || a - b == c || a * b == c || (a / b == c && a % b == 0))
                return true;
            return false;

        }

        

        bool tennisSet(int score1, int score2)
        {

            int diffScores = Math.Abs(score1 - score2);

            if ((score1 == 7 && score2 < 5) || (score2 == 7 && score1 < 5))
                return false;
            if ((score1 == 6 && score2 == 5) || (score1 == 5 && score2 == 6))
                return false;
            if (diffScores >= 1 && (score1 <= 7 && score2 <= 7) && (score1 >= 6 || score2 >= 6))
            {
                return true;
            }

            return false;
        }

        bool willYou(bool young, bool beautiful, bool loved)
        {

            if ((!beautiful && young && loved) || (beautiful && !young && loved))
                return true;
            if ((young && beautiful && !loved) || (!young && !beautiful && loved))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
