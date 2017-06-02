using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class PattenPrint
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
}
