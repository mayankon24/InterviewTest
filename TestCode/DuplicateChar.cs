using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class DuplicateChar
    {

        public void run()
        {
            Dictionary<char, int> list = new Dictionary<char, int>();
            
            Console.WriteLine("Enter input array");
            string input = Console.ReadLine();

            foreach (char item in input)
            {
                if (list.ContainsKey(item))
                {
                    Console.WriteLine("this is not unique");
                    return;
                }
                else
                {
                    list[item] = 1;
                }

            }
            Console.WriteLine("this is unique");
            Console.ReadLine();
        }
    }
}
