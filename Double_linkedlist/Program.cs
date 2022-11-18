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

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }

            /*if the node is to be inserted at beetwen two node*/
            Node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {

                if (nim == current.noMhs)
                {
                    Console.WriteLine("Duplicate roll numbers not allowed");
                    return;
                }
            }
         /*on the execution of the above for loop, prev and
         * current will point to those nodes
         * between which the new node is to be inserted*/
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list
            if(current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
        }

        public bool Search
    }
}
