using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_CountingSort
{
    class Program
    {
        static int[] Counting(int[] A, int[] B, int k)
        {
            int[] C = new int[k];

            for (int i = 0; i < A.Length; i++)
                C[A[i]]++;

            for (int i = 1; i <k; i++)
                C[i] += C[i - 1];

            for (int i = A.Length - 1; i >= 0; i--)
            {
                B[C[A[i]]] = A[i];
                C[A[i]]--;
            }

            return B;
        }

        static int[] MyCounting(int[] A, int[] B, int k)
        {
            int[] C = new int[k];

            for (int i = 0; i < A.Length; i++)
                C[A[i]]++;

            for (int i = 1; i < k; i++)
                C[i] += C[i - 1];

            for (int i = 0; i < A.Length; i++)
            {
                B[C[A[i]]] = A[i];
                C[A[i]]--;
            }

            return B;
        }

        static void Main(string[] args)
        {
            int[] A = new int[]{ 6,0,2,5,4,3,4,6,5,3,2 };
            int[] B = new int[A.Length + 1];
            int k = A.Max() + 1;
            MyCounting(A, B, k);
            
        }
    }
}
