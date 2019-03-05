using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackInt
{
    public class stackChar
    {
        char[] A;
        int top = -1;

        public stackChar(int Size)
        {
            A = new char[Size];
        }

        public void Push(char x)
        {
            top++;
            A[top] = x;
        }

        public void Pop()
        {
            top--;
        }

        public char Top()
        {
            return A[top];
        }

        public Boolean isEmpty()
        {
            return top == -1;
        }
    }
}
