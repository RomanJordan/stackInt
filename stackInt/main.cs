using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackInt
{
    public class main
    {
        public static int evalPostFix(String postFix)
        {
            stackInt stack = new stackInt(postFix.Length);

            for (int i = 0; i < postFix.Length; i++)
            {
                char c = postFix[i];
                if (isOperator(c))
                {
                    int operandB = stack.Top(); stack.Pop();
                    int operandA = stack.Top(); stack.Pop();

                    if (c == '*') stack.Push(operandA * operandB);
                    if (c == '/') stack.Push(operandA / operandB);
                    if (c == '+') stack.Push(operandA + operandB);
                    if (c == '-') stack.Push(operandA - operandB);
                    }

                    else
                    {
                        stack.Push(c - '0');
                    } 
                
            }
            return stack.Top();
        }

        public static String infix2PostFix(String infix)
        {
            String postFix = "";

            stackChar stack = new stackChar(infix.Length / 2);

            for (int i = 0; i < infix.Length; i++)
            {

            }
            return postFix;
        }

        public static int prec(char op)
        {
            if (op == '^') return 3;
            if (op == '*') return 2;
            if (op == '/') return 2;
            if (op == '+') return 1;
            if (op == '-') return 1;
            
            /*if (op == '(')*/ return 0; // If the operand is an open parenthesis, return 0;
        }


        public static bool isOperator(char c)
        {
             return (c == '*') || (c == '/') || (c == '+') || (c == '-');
        }

        public static String reverseString(String s)
        {
            String result = "";
            stackChar stack = new stackChar(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }

            for (int j = 0; j < s.Length; j++)
            {
                result += stack.Top(); stack.Pop();
            }
            
            return result;
        }

        public static bool checkPalindrom(String s)
        {
            String firstRead = s;
            String secondRead = "";
            stackChar stack = new stackChar(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);

            }

            for (int j = 0; j < s.Length; j++)
            {
                
                secondRead += stack.Top(); stack.Pop();
            }

            if (firstRead.Equals(secondRead, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
        static void Main(string[] args)
        {
            String post = "123*+";
            int result = evalPostFix(post);
            //bool result = checkPalindrom("cat");

            Console.WriteLine(result);
            Console.ReadLine();
           
        }


    }
}
