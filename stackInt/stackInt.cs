using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackInt
{
    public class stackInt
    {
        int[] A;
        int top = -1;

        public stackInt(int Size)
        {
            A = new int[Size];
        }

        public void Push(int x)
        {
            top++;
            A[top] = x;
        }

        public void Pop()
        {
            top--;
        }

        public int Top()
        {
            return A[top];
        }

        public Boolean isEmpty()
        {
            return top == -1;
        }
    }
}
