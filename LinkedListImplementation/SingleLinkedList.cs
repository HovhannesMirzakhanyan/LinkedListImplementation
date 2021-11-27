using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class SingleLinkedList<T>
    {
        private  Node<T> _head;
        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = _head;
            _head = new_node;
        }
        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (_head == null)
            {
                _head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.next = new_node;
        }
        internal Node<T> GetLastNode()
        {
            Node<T> temp = _head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }

    
    public class Node<T>
    {
        internal T data;
        internal Node<T> next;
        public Node(T value)
        {
            data = value;
            next = null;
        }
    }
}
