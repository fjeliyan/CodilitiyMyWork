using System;

namespace TimeComplexity
{


    /**A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.

Count the minimal number of jumps that the small frog must perform to reach its target.

Write a function:

class Solution { public int solution(int X, int Y, int D); }

that, given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.

For example, given:

  X = 10
  Y = 85
  D = 30
the function should return 3, because the frog will be positioned as follows:

after the first jump, at position 10 + 30 = 40
after the second jump, at position 10 + 30 + 30 = 70
after the third jump, at position 10 + 30 + 30 + 30 = 100
Write an efficient algorithm for the following assumptions:

X, Y and D are integers within the range [1..1,000,000,000];
X ≤ Y.
     */
    internal class FrogJump
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"i {i} j{j}");
                    if (j== 1)
                    {
                        break;
                    }
                }
            }
            int X = 10;
            int Y = 85;
            int D = 30;

           // Console.WriteLine($"Solution is  {solution(X, Y, D)}");
        }

        public static int solution(int X, int Y, int D)
        {
            //%100 correct 
            int step = 0;
            int diff = Y - X; //85 -10 = 75

            step = (diff / D); // 75 division 30 = 2
            if (diff % D > 0) //75 modulo 30 = 15 than we need one extra step
            { step++; }

            return step;
            // Second solution without goed performans 

            //int i = 0;
            //if (Y > X)
            //{
            //    do
            //    {
            //        X = X + D;
            //        i++;
            //    } while (X < Y);

            //}
            //return i;
           










        }
    }
}
