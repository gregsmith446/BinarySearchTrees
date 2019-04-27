using System;

namespace _22BinarySearchTrees
{
    class Node
    {
        // 2 nodes, left and right
        public Node left;
        public Node right;

        // integer data
        public int data;

        // function that takes data, an integer and adds it to the node = left or right
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {
        // this function counts the # of edges between the tree's root and furthest leaf
        // then it return the max height of the BST
        static int getHeight(Node root)
        {
            // check to see if tree is empty
            if (root == null)
            {
                return -1;
            }
            else
            {
                // find the height of left and right sides of tree
                int heightLeft = 1 + getHeight(root.left);
                int heightRight = 1 + getHeight(root.right);

                // return the left or right sides' height - whichever is larger
                return (heightLeft > heightRight ? heightLeft : heightRight);
            }
        }

        // this function inserts the nodes into the BST
        // the logic ensures the nodes are added to the BST correctly
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

            // obtain the num of nodes to expect
            Console.WriteLine("The amount of nodes in the BST: ");
            int T = Int32.Parse(Console.ReadLine());

            // get the nodes and add them to the BST
            Console.WriteLine("Give nodes, hitting enter after each entry");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            // calculate max height of BST + print result
            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}



