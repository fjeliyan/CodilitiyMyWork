using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    /**
     * A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

For example, in array A such that:

  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the elements at indexes 0 and 2 have value 9,
the elements at indexes 1 and 3 have value 3,
the elements at indexes 4 and 6 have value 9,
the element at index 5 has value 7 and is unpaired.
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

For example, given array A such that:

  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the function should return 7, as explained in the example above.

Write an efficient algorithm for the following assumptions:

N is an odd integer within the range [1..1,000,000];
each element of array A is an integer within the range [1..1,000,000,000];
all but one of the values in A occur an even number of times.
     */
    internal class OddOcurrencesInArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 9, 1, 9, 3, 9, 9, 1, 3, 201 };
            Console.WriteLine(solution(A));

        }
        public static int solution(int[] A)
        {
            //HashSet is a collection that contains no duplicate elements and whose elements are in no particular order 
            //HashSet<T> class is not sorted and cannot contain duplicate elements.
            //HashSet<T> means the specified uniqe collection
            //Create one empty HashSet
           var has = new HashSet<int>();

           foreach (var i in A)
                //if has contains i remove 
                if (has.Contains(i))
                    has.Remove(i);
                else
                    //if not add i 
                    has.Add(i);
            foreach (var i in has)
                return i;
            return 0;


        }

    }
}
