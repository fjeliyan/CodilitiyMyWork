using System;
using System.Linq;

namespace ConsoleApp1
{
    /*An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. 
     * For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).

The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

class Solution { public int[] solution(int[] A, int K); }

that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given

    A = [3, 8, 9, 7, 6]
    K = 3
the function should return [9, 7, 6, 3, 8]. Three rotations were made:

    [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
    [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
    [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
For another example, given

    A = [0, 0, 0]
    K = 1
the function should return [0, 0, 0]

Given

    A = [1, 2, 3, 4]
    K = 4
the function should return [1, 2, 3, 4]

Assume that:

N and K are integers within the range [0..100];
each element of array A is an integer within the range [−1,000..1,000].
In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
     */
    internal class OddOcurrencesInArray
    {

        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 5, 1 };
            //result is 35112

            Console.WriteLine(solution(A, 8));
            Console.WriteLine(solutionCase(A, 8));

        }
        public static int[] solutionCase(int[] A, int K)
        {
            var r = new int[A.Length];
            if (r.Length > 0)
                for (int i = -1, j = A.Length - (K % A.Length); ++i < A.Length;)
                    r[i] = A[(j + i) % A.Length];
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
            return r;
        }
        public static int[] solution(int[] A, int K)
        {
            //initialize B array with length of array A 
            int[] B = new int[A.Length];

            //Check A.Lengthe is null or K is 0 or K is same lengthe of A
            if (A.Length == 0 || K == 0 || (K == A.Length))
            {
                // IS TRUE RETURN A 
                return A;
            }
            //I need a loop to run in de Array with K times 
            for (int i = 0; i < K; i++)
            {
                //Get last element of A 
                int indexLastRemove = A[A.Length - 1];
                //Remove last index in the Array A
                A = A.Where((source, e) => e != A.Length - 1).ToArray();
                // Set last element of A in first index of B
                B[0] = indexLastRemove;
                //index start 1 
                int index = 1;
                //loop in de A and add item of A in B 
                foreach (var item in A)
                {
                    B[index] = item;
                    index++;
                }
               //A is nu B
                A = B;

            }



            foreach (var item in B)
            {
                Console.WriteLine($"B is {item}");
            }

            return B;
        }
    }
}
