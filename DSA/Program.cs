
using DSA.ADT;
using DSA.BinarySearchTree;
using DSA.Linked_Lists;
using DSA.Stack;
using System;
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

BinarySearchTree bst = new BinarySearchTree();

bst.Insert(10, "First");
bst.Insert(7, "Second");
bst.Insert(6, "Third");
bst.Insert(1, "Fourth");
bst.Insert(8, "Fifth");
bst.Insert(9, "Fifth"); 
bst.Insert(11, "Fifth"); 
bst.Insert(20, "Fifth"); 
bst.Insert(14, "Fifth"); 
bst.Insert(22, "Fifth");

//Console.WriteLine(bst.Find(151));

// Bubble Sort, very inefficient, what not to do, O(n^2) Quadratic time complexity

//int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

//int[] BubbleSort(int[] array)
//{
//    // hold the temporary swap variable
//    int temp;

//    for (int pointer = 0; pointer < array.Length; pointer++)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] > array[i+1])
//            {
//                temp = array[i+1];
//                array[i+1] = array[i];
//                array[i] = temp;
//            }
//        }
//    }

//    return array;
//}

//foreach (int number in BubbleSort(intArray))
//{
//    Console.WriteLine(number);
//}

// Tree traveral

// In-Order depth first

Console.WriteLine("==========================");
Console.WriteLine("In Order");
bst.PrintInOrderTraversal();
Console.WriteLine("==========================");

// Pre-Order 

Console.WriteLine("==========================");
Console.WriteLine("Pre Order");
bst.PrintPreOrderTraversal();
Console.WriteLine("==========================");

// Post-Order

Console.WriteLine("==========================");
Console.WriteLine("Post Order");
bst.PrintPostOrderTraversal();
Console.WriteLine("==========================");