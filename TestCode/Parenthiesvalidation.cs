using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Parenthiesvalidation
    {

        public void run()
        {
            Console.WriteLine("Enter input expression");
            string exp = Console.ReadLine();

            Stack S = new Stack(100);
            bool IsValid =true;

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    S.push(exp[i]);
                }
                else
                {
                    if (exp[i] == '}')
                    {
                        char temp = S.pop();
                        if (temp != '{')
                        {
                            IsValid = false;
                            break;
                        }
                    }
                    if (exp[i] == ']')
                    {
                        char temp = S.pop();
                        if (temp != '[')
                        {
                            IsValid = false;
                            break;
                        }
                    }
                    if (exp[i] == ')')
                    {
                        char temp = S.pop();
                        if (temp != '(')
                        {
                            IsValid = false;
                            break;
                        }
                    }
                }
            }

            if (S.isEmpty() == false)
            {
                IsValid = false;
            }

            if (IsValid)
            {
                Console.WriteLine("this ia valid expression");
            }
            else
            {
                Console.WriteLine("this ia not valid expression");
            }
            Console.ReadLine();

        }
    }


    public class Stack
    {
        char[] s;
        int index = 0;

        public Stack(int N)
        {
            s = new char[N];
        }


        public void push(char c)
        {
            if (index>= s.Length)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                s[index] = c;
                index = index + 1;
            }
        }

        public char pop()
        {
            if (index == 0)
            {
                Console.WriteLine("Stack is empty");
                return default(char);
            }
            else
            {
                index = index - 1;
                char value = s[index];
                s[index] = default(char);
                return value;
            }
        }

        public bool isEmpty()
        {

            if (index <=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
