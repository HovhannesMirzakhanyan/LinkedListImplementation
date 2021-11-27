using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> singleLinkedList = new SingleLinkedList<string>();
            //singleLinkedList.InsertFront("aaaa");
            //singleLinkedList.InsertFront("bbbb");
            //singleLinkedList.InsertFront("cccc");
            singleLinkedList.InsertLast("aaaa");
            singleLinkedList.InsertLast("bbbb");
            singleLinkedList.InsertLast("cccc");

            DoubleLinkedList<string> doubleLinkedList = new DoubleLinkedList<string>();
            //doubleLinkedList.InsertFront("aaaa");
            //doubleLinkedList.InsertFront("bbbb");
            //doubleLinkedList.InsertFront("cccc");
            //doubleLinkedList.InsertFront("dddd");
            doubleLinkedList.InsertLast("aaaa");
            doubleLinkedList.InsertLast("bbbb");
            doubleLinkedList.InsertLast("cccc");
            doubleLinkedList.InsertLast("dddd");


        }
    }
}
