using System;

namespace myList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new myLinkedList();
            myList.addStart(23);
            myList.addStart(12);
            myList.addEnd(52);
            myList.AddSorted(11);

            myList.Print();
        }
    }
}
