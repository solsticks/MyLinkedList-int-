using System;

namespace myList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new myLinkedList();
            myList.addEnd(12);
            myList.addStart(11);
            

            

            Console.WriteLine(myList.Count); 
            myList.Print();

            //var test = new Node(23);
            //test.addToEnd(24);
            //test.Remove();
            //test.Print();
        }
    }
}
