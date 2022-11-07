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

            START = null;// add a node in the list


        }
        public void addnote()
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






        }


    }
     class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
