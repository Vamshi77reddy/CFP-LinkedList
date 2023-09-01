using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList<T>
    {
        Node<T> head;
        Node<T> tail;
        public void AddFirst(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddLast(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("No Data Avaliable");
            }
            else
            {
                Console.WriteLine(head.Data + "  deleted successfully");
                head = head.next;
            }
        }

        public void DeleteLast()
        {

            if (head == null)
            {
                Console.WriteLine("No Data Avaliable");
            }
            if (head == tail)
            {
                Console.WriteLine(head.Data + " Deleted successfully");
                head = null;
            }

            Node<T> TempNode = head;
            while (TempNode.next != tail)
            {
                TempNode = TempNode.next;

            }
            if (TempNode.next == tail)
            {
                Console.WriteLine(tail.Data + " Deleted successfully");
                TempNode.next = null;
                tail = TempNode;
            }
        }
        public void InsertAfter(T data, T search)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            Node<T> temp2 = head;
            while (temp != null && temp2 != null)
            {
                if (temp.Data.Equals(search))
                {
                    temp2 = temp2.next;
                    temp.next = newNode;
                    newNode.next = temp2;
                    Console.WriteLine("Data inserted successfully!!");
                }
                temp = temp.next;
                temp2 = temp2.next;
            }
        }

        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
