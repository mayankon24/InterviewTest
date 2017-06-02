using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
   public class Fibonnic
    {

        public void run()
        {
            int a = 0;
            int b = 1;
            int count = Convert.ToInt32(Console.ReadLine());

            if (count <= 0)
            {
                return;
            }
            if (count == 1)
            {
                Console.WriteLine(a);
                return;
            }

            if (count == 1)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                return;
            }


            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = 0;
            for (int i = 0; i < count-2; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }


            Console.ReadLine();

        }
    }
}
