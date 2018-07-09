using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class IsHappyNo
    {
        public void run()
        {
            Console.WriteLine("Please enter Input No");
            int N = Convert.ToInt32(Console.ReadLine());

            HashSet<int> hash = new HashSet<int>();
            bool Ishappy = false;

            while (true)
            {

                N = GetSquareSum(N);
                if (N == 1)
                {
                    Ishappy = true;
                    break;
                }
                else
                {
                    if(hash.Contains(N))
                    {
                        break;
                    }
                    else
                    {
                        hash.Add(N);
                    }
                }

            }

            if (Ishappy)
            {
                Console.WriteLine("this is happy no");
            }
            else
            {
                Console.WriteLine("this is not happy no");
            }
            Console.ReadLine();
        }


        private int GetSquareSum(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                int modular = N % 10;
                sum = sum + (modular * modular);
                N = N / 10;
            }
            return sum;
        }
    }
}
