using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearchTree
{
    public class TreeNode
    {
        public int key { get; set; }

        public string value { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public TreeNode(int key, string value) 
        {
            this.key = key;
            this.value = value;
        }

    }
}
