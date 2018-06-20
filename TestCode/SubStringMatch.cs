using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class SubStringMatch
    {

        public void run()
        {

            Console.WriteLine("Enter first string");
            string S1= Console.ReadLine();

            Console.WriteLine("Enter second string");
            string S2 = Console.ReadLine();


            for (int i = 0, j=0; i < S1.Count(); i++)
            {

                if (S1[i] == S2[j])
                {
                    j = j + 1;

                    if (j == S2.Count())
                    {
                        Console.WriteLine( (i - j + 1));
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    j = 0;
                }


            }
            Console.WriteLine(-1);
            Console.ReadLine();
        }
    }
}
