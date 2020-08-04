using System;
using System.Collections.Generic;
using System.Text;

namespace myList
{
    class Node
    {
        public int data;
        public Node Next;

        public Node(int data)
        {
            this.data = data;
            Next = null;
        }

        public void addToEnd(int data)
        {
            if (Next == null)
            {
                Next = new Node(data);
            }
            else
            {
                Next.addToEnd(data);
            }
        }

       
        public void addSorted(int data)
        {
            if (Next == null)
            {
                Next = new Node(data);
            }
            else if (data < Next.data)
            {
                Node temp = new Node(data);
                temp.Next = this.Next;
                this.Next = temp;
            }
            else
            {
                Next.addSorted(data);
            }
        }

        public void Print()
        {
            Console.Write($"{data}->");
            if (Next != null)
            {
                Next.Print();
            }
        }
    }
}
