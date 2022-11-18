using System;

namespace Double_linkedlist
{
    class Node
    {
        /*NodeClass represent the node od doubly linked list 
         *it consist of the information part and links to 
         *its succedeing and preceeding
         *in therm of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the precceding node
        public Node prev;

    }
    class DoubleLinkedList
    {
        Node START;

        //CONSTRUCTOR

        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

        }
    }
}
