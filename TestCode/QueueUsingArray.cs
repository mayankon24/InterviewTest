using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class QueueUsingArray
    {

        public void run()
        {
            Console.WriteLine("Enter Row no");
            int row =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Column no");
            int Column = Convert.ToInt32(Console.ReadLine());


            if (row <= 0 || Column <= 0)
            {
                Console.WriteLine("");
                return;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }



    }

    class queue
    {
        int[] A;
        int S =0, E = 0;
        int N;
        int queueSize = 0;

        queue(int n)
        {
            A = new int[n];
            N = n;
        }

        int dequeue()
        {
            if (queueSize == 0)
            {
                Console.WriteLine("Queue is empty");
            }

            int returnvalue = A[S];
            A[S] = default(int);

            if (S == 0)
            {
                S = S - 1;
            }
            else if (S == A.Length - 1)
            {

            }

            if (S == A.Length-1 )
            {
                if (S-E <= A.Length)
                {

                }
            }
            else
            {

            }

            return returnvalue;
        }


    }
}
