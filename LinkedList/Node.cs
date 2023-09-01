using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class Node<T>
    {
        public T Data;
        public Node<T> next;

        public Node()
        {

        }
        public Node(T Data)
        {
            this.Data = Data;
        }
    }
}
