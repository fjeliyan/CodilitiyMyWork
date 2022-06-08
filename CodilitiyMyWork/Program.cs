using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    string binary = Convert.ToString(33, 2);

        //    Console.WriteLine(binary);
            
          
        //    Console.WriteLine(SolutionBinary(298368897));
           // int[] A = new int[] { 1, 3, 6, 4, 1, 2 };//5
           // int[] B = new int[] { 1, 3, 2};//4
           // int[] C = new int[] { -1, -3};//1
           // Console.WriteLine(soluiton(A));
           //Console.WriteLine(soluiton(B));
           // Console.WriteLine("C" + soluiton(C));
       // }

        /// <summary>
        /// BINARY GAPS 
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
       

        //ARRAY find next first number doesn't exits in list 
        public static int soluiton(int[] A)
        {
          // Array change to list 
            List<int> B = A.ToList();
            //Sort the list 
            B.Sort();
            // First value 
            int first = 0;
            int maxValue = B.Max(); 

            foreach (int i in B)
            {
                if (i > 0)
                {
                    if (i - first > 1)
                    {

                      return  first + 1;

                    }
                    else
                    {
                        first = i;
                    }
                }
               
            }
            // first value is 0 return 1
            if (first == 0)
            {
                return 1;
            }
            // first value is gelijk met maxValue van the list 
            if (first == maxValue)
            {
                return first + 1;
            }
            return  0;
        }

    }
}
