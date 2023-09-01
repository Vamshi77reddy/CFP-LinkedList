using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*LinkedList<String> Student = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            Student.AddLast("Zoya");
            Student.AddLast("Shilpa");
            Student.AddLast("Rohit");
            Student.AddLast("Rohan");
            Student.AddLast("Rani");
            Student.AddLast("Rohith");

            Console.WriteLine("Students are :");

         
            foreach (string str in Student)
            {
                Console.WriteLine(str);
            }


            // Check if the given element is available or not

            if (Student.Contains("Shilpa") == true)
            {
                Console.WriteLine("Element Found...!!");
            }
            else
            {
                Console.WriteLine("Element Not found...!!");
            }

            Console.WriteLine("Removing first element using RemoveFirst() method");

            Student.RemoveFirst();

            foreach (string str in Student)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Removing Last element using RemoveLast() method");

            Student.RemoveLast();

            foreach (string str in Student)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Removing Last element using RemoveLast() method");

            var n = Student.AddFirst("Sai");
            Student.AddBefore(n, "Rohith");
            foreach (var d in Student)
            {
                Console.WriteLine(d);
            }*/


            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("A");
            list.AddFirst("B");
            list.AddFirst("C");
            list.AddFirst("D");
            list.AddFirst("E");

            list.Display();
            Console.WriteLine();
            list.AddLast("z");
            list.Display();
            Console.WriteLine();
            list.DeleteFirst();
            list.Display();
            Console.WriteLine();
            list.DeleteLast();
            list.Display();
            Console.WriteLine();
            list.Display();
            Console.WriteLine();
            list.InsertAfter("Vamshi", "C");
            list.Display();
        }
    }
    }

