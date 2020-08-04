using System;
using System.Collections.Generic;
using System.Text;

namespace myList
{
    class myLinkedList
    {
        public Node headNode;
        public Node Tail;
        public int Count;


        public myLinkedList()
        {
            headNode = null;
            Count = 0;

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
            Count++;
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
            Count++;
            return;
        }

        //public void AddSorted(int data)
        //{
        //    if (headNode == null)
        //    {
        //        headNode = new Node(data);
        //    }
        //    else if (data < headNode.data)
        //    {
        //        addStart(data);
        //    }
        //    else
        //    {
        //        headNode.addSorted(data);
        //    }
        //    Count++;
        //}

        public void Remove()
        {
            if (headNode != null)
            {

            }
        }

        public void Pop()
        {
            var current = headNode;
            var prev = current;
            if (current == null)
            {
                Console.WriteLine("The list is empty");                
            }
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;              
            }
            Tail = prev;
            Tail.Next = null;
            Count--;            
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
