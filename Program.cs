using System;

namespace _22BinarySearchTrees
{
    class Node
    {
        public Node left;
        public Node right;

        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {
        static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                int heightLeft = 1 + getHeight(root.left);
                int heightRight = 1 + getHeight(root.right);

                return (heightLeft > heightRight ? heightLeft : heightRight);
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if (data <= root.data)
                {
                    current = insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;

            Console.WriteLine("The amount of nodes in the BST: ");
            int T = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Give nodes, hitting enter after each entry");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            int height = getHeight(root);
            Console.WriteLine("The maximum height, or longest path of the given binary tree is {0} edges.", height);
        }
    }
}



