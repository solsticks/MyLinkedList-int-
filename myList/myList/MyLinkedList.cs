using System;
using System.Collections.Generic;
using System.Text;

namespace myList
{
    class myLinkedList
    {
        public Node headNode;


        public myLinkedList()
        {
            headNode = null;

        }

        public void addEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.addToEnd(data);
            }
        }

        public void addStart(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.Next = headNode;
                headNode = temp;

            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }


    }
}
