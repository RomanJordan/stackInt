using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackInt
{
    class Node
    {
        readonly int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
           
        }
    }

    public class LinkedList
    {
        Node head;

        public void Append(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }

    }


}
