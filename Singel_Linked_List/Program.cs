using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singel_Linked_List
{
    //each node consist the information part and link to next node
    class Node
    {
        public int RollNumber;
        public string Name;
        public Node Next;



    }




    class list
    {

        Node START;
        public list()
        {

            START = null;

        }
        public void addnote()// add a node in the list

        {
            int rollNo;
            string nm;
            Console.Write("\n Enter the roll number of the student : ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the roll number of the student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.RollNumber = rollNo;
            newnode.Name = nm;

            //if the node to be inserted is the first node
            if(START == null || (rollNo <= START.RollNumber))
            {
                if (START != null && (rollNo == START.RollNumber))
                {

                    Console.WriteLine();
                    return;


                }
                newnode.Next = START;
                START = newnode;
                return;



            }

            Node preveious, current;
            preveious = START;
            current = START;


            while((current != null)&&(rollNo >= current.RollNumber))
            {
                if (rollNo == current.RollNumber)
                {
                    Console.WriteLine();
                    return;

                }
                preveious.Next = current;
                preveious.Next = newnode;
            }
            newnode.Next = current;
            preveious.Next = newnode;
        }

        public bool delnote(int rollNo)
        {
            Node preveious, current;
            preveious = current = null;

            if (Search(rollNo, ref preveious, ref current) == false)
                return false;
            preveious.Next = current.Next;
            if (current == START)
                START = START.Next;
            return true;

        }

        public bool Search(int rollNo, ref Node preveious, ref Node current)
        {
            preveious = START;
            current = START;
            while ((current != null) && (rollNo != current.RollNumber))
            {
                preveious = current;
                current = current.Next;

            }
            if (current == null)
                return false;
            else
                return true;
        }

        public void Treverse()
        {

            if (listEmpty())
                Console.WriteLine();
            else
            {
                Console.WriteLine();
                Node currentNode;
                for (currentNode = START; currentNode != null;
                     currentNode = currentNode.Next)
                    Console.WriteLine(currentNode.RollNumber + ""
                    + currentNode.Name + "\n");
                Console.WriteLine();


            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }



    }
     class Program
    {
        static void Main(string[] args)
        {
            list obj= new list();
            while (true)
            {
              try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list ");
                    Console.WriteLine("2. Delete a record from the list ");
                    Console.WriteLine("3. View all records in the list ");
                    Console.WriteLine("4. Search for a record in the list ");
                    Console.WriteLine("5. Exit ");
                    Console.WriteLine("\nEnter your choice (1-5) :");
                    char ch = Convert.ToChar(Console.ReadLine());

                }
            }




        }
        
    }
}
