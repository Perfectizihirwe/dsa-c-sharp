using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class Stack
    {
        // Linked list to hold our data
        public LinkedList<int> stackData { get; set; }
        // Variable to keep track of our top 
        public int Top { get; set; }

        public Stack() {

            stackData = new LinkedList<int>();

            Top = -1;
        }

        public void Push(int x)
        {
            stackData.AddFirst(x);
            Top++;
        }

        public int Pop()
        {
            var popped = stackData.First();
            stackData.RemoveFirst();
            return popped;
        }

        public int Peek()
        {
            return stackData.Last();
        }
    }
}
