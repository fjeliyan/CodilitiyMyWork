using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    /**
 * Binary Gap
 * A binary Gap within a positive integer N is any maximal sequence of consecutive
 * zeros that is surrounded by ones at both ends in the binary representation of N.
 * For example, number 9 has a binary representation 1001 and contains a binary
 * gap of length 2. The number 529 has binary representation 1000010001 
 * and contains two binary gaps: one of length 4 and one of length 3. The number
 * 20 has binary representation 1111 and has no binary gaps.
   Write a function: 
	class Solution { public int solution(int N); }
 * that, given a positive integer N, returns the length of its longest
 * binary gap.The function should return 0 if N doesn’t contain a binary gap.
 * For example, given N = 1041 the function should return 5, because N has binary
 * representation 10000010001 and so its longest binary gap is of length 5.
 * Assume that: 
    •	N is an integer within the range[1..2, 147, 483, 647],
 * Complexity:
    •	Expected worst-case time complexity is O(log(N));
    •	Expected Worst-case space complexity is O(1).
 *
 */
    internal class BinaryGap
    {
        //static void Main(string[] args)
        //{
        //   Console.WriteLine(SolutionBinary(298368897));
        //}

        public static int SolutionBinary(int N)
        {

            string binary = Convert.ToString(N, 2);
            string[] Barry = binary.Select(c => c.ToString()).ToArray();
            int resultGap = 0;

            int teller = 0;
            for (int i = 0; i < Barry.Length; i++)
            {
                if (Barry[i] == "0")
                {
                    teller++;
                    continue;
                }
                else if (Barry[i] == "1")
                {
                    if (teller > resultGap)
                    {
                        resultGap = teller;
                        teller = 0;
                    }
                    else
                    {
                        teller = 0;
                    }

                }


            }
            return resultGap;


        }
    }
}
