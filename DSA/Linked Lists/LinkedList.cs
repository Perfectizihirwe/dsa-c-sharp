//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA.Linked_Lists
//{
//    public class LinkedList
//    {
//        public Node Head = new Node() { Data = null, Next = null };

//        public void InsertHead(int data)
//        {
//            // Create the node
//            Node newNode = new Node();
//            // Put the data in the node
//            newNode.Data = data;
//            // Put old node in next
//            newNode.Next = Head;
//            // Assign head to new node
//            Head = newNode;

//        }

//        public Node DeleteHead()
//        {
//            // Make a temporary variable
//            Node temp = new Node();
//            // Assign new head
//            Head = Head.Next;
//            // Return deleted head
//            return temp;

//        }

//        public void DisplayList()
//        {
//            // Make a current
//            Node current = Head;
//            while (current != null)
//            {
//               current.DisplayNode();
//               current = current.Next;
//            }
//        }

//        public void InsertAtEnd(int data)
//        {
//            // Make the new node
//            Node newNode = new Node() { Data = data };
//            // Make a current
//            Node current = Head;
//            while (current != null)
//            {
//                current = current.Next;
//            }
//            if(current == null)
//            {
//                current = newNode;
//                current.Next = null;
//            }
//        }
//    }
//}
