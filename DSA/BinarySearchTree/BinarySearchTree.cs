using DSA.Linked_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        public TreeNode InsertItem(TreeNode root, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            // Only on the first insert
            if (root == null)
            {
                root = newNode;
                return root;
            }

            // If not the first insert, traverse tree
            if (key < root.key)
            {
                root.LeftChild = InsertItem(root.LeftChild, key, value);
            }
            else
            {
                root.RightChild = InsertItem(root.RightChild, key, value);
            }
            return root;
        }

        public void PrintInOrderTraversal()
        {
            InOrderTraversal(Root);
        }

        public void InOrderTraversal(TreeNode root)
        {
            if (root is not null)
            {
                InOrderTraversal(root.LeftChild);
                Console.WriteLine(root.key + " " + root.value);
                InOrderTraversal(root.RightChild);
            }
        }

        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }

        public void PreOrderTraversal(TreeNode root)
        {
            if (root is not null)
            {
                Console.WriteLine(root.key + " " + root.value);
                InOrderTraversal(root.LeftChild);
                InOrderTraversal(root.RightChild);
            }
        }

        public void PrintPostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        public void PostOrderTraversal(TreeNode root)
        {
            if (root is not null)
            {
                InOrderTraversal(root.LeftChild);
                InOrderTraversal(root.RightChild);
                Console.WriteLine(root.key + " " + root.value);
            }
        }

        public string Find(int key)
        {
            TreeNode node = FindItem(Root, key);
            return node == null ? null : node.value;
        }

        public TreeNode FindItem(TreeNode node, int key)
        {
            if (node == null || node.key == key)
            {
                return node;
            }
            else if (key < node.key)
            {
                return FindItem(node.LeftChild, key);
            }
            else
            {
                return FindItem(node.RightChild, key);
            }
        }
    }
}
