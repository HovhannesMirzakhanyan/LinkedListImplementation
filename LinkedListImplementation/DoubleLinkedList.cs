using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class DoubleLinkedList<T>
    {
        private  DNode<T> _head;
        public  void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = _head;
            newNode.prev = null;
            if (_head != null)
            {
                _head.prev = newNode;
            }
            _head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (_head == null)
            {
                newNode.prev = null;
                _head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        internal DNode<T> GetLastNode()
        {
            DNode<T> temp = _head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException();
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
    }
    internal class DNode<T>
    {
        internal T data;
        internal DNode<T> prev;
        internal DNode<T> next;
        public DNode(T value)
        {
            data = value;
            prev = null;
            next = null;
        }
        
    }
   
}
