
using DSA.ADT;
using DSA.BinarySearchTree;
using DSA.Linked_Lists;
using DSA.Stack;
using System.Collections;

// Abstract data types

//Pokemon squirtle = new Pokemon();

//Stack test = new Stack();

//string[] students = new string[6];

//int length = 0;

//for(int i = 0; i < 4; i++)
//{
//    students[length] = "Student " + (i+1).ToString();
//    length++;
//}

// Insert at the end of an array

//students[length] = "Student " + (length+1).ToString();
//length++;

// Insert at the beginning of an array

//for (int i = 3;i >= 0; i--)
//{
//    students[i+1] = students[i];
//}


// students[0] = "New student"; 

// Inserting Anywhere in an array

//for (int i = 4; i >= 2; i--)
//{
//    students[i + 1] = students[i];
//}

//students[2] = "New student";

// Linked lists represantation (Nodes)

//Node nodeA = new Node();

//nodeA.Data = 48;

//Node nodeB = new Node();

//nodeB.Data = 78;

//Node nodeC = new Node();

//nodeC.Data = 23;

//Node nodeD = new Node();

//nodeD.Data = 90;

//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD; 

// Linked List operations

//LinkedList linkedList = new LinkedList();

//linkedList.InsertHead(1);
//linkedList.InsertHead(2);
//linkedList.InsertHead(3);
//linkedList.InsertHead(4);
//linkedList.InsertHead(5);

//linkedList.DisplayList();

// Stack

//Stack stack = new Stack();

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//stack.Push(5);

//stack.Pop();
//stack.Push(6);

//var joker = "";

//Console.WriteLine(stack.Peek());

//Queue queue = new Queue();

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Enqueue(5);

//queue.Dequeue();
//queue.Dequeue();

//queue.Enqueue(078);

//queue.Peek();

// Paranthesis Question to solve with stack

//string paranthesisString = "{[]}";

//Stack<char> symbols = new Stack<char>();

//foreach (char c in paranthesisString.ToCharArray())
//{
//    if (c == '(' || c == '{' || c == '[')
//    {
//        symbols.Push(c);
//    }
//    else if((c == ')') && !(symbols.Count == 0) && symbols.Peek() == '(')
//    {
//        symbols.Pop();
//    }
//    else if ((c == '}') && !(symbols.Count == 0) && symbols.Peek() == '{')
//    {
//        symbols.Pop();
//    }
//    else if ((c == ']') && !(symbols.Count == 0) && symbols.Peek() == '[')
//    {
//        symbols.Pop();
//    }
//}

//Console.WriteLine(symbols.Count + "Sysmbols Count");

// Binary Search(Data must be sorted)

//int[] array = { -20, -15, 2, 7, 20, 30, 54 };

//int BinarySearch(int[] array, int value)
//{
//    int start = 0;
//    int end = array.Length;

//    while (start < end)
//    {
//        int middle = (start + end) / 2;
//        // Search middle of the book
//        if(array[middle] == value)
//        {
//            return middle;
//        }
//        // Assign new middle
//        else if (value > array[middle])
//        {
//            start = middle + 1;
//        } 
//        else
//        {
//            end = middle;
//        }
//    }

//    return -1;
//}

//Console.WriteLine(BinarySearch(array, 54));

// Binary Search Tree

BinarySearchTree bst  = new BinarySearchTree();

bst.Insert(7, "First");
bst.Insert(23, "Second");
bst.Insert(151, "Third");
bst.Insert(4, "Fourth");
bst.Insert(1, "Fifth");

Console.WriteLine(bst.Find(151));