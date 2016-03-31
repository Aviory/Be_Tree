using System;

namespace BeTree
{
    public class BStree
    {
        class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node(int val)
            {
                this.val = val;
            }
        }

        Node root = null;

        public void init(int[] ar)
        {
            clear();
            foreach (int p in ar)
            {
                add(p);
            }
        }
             

        public void clear()
        {
            root = null;
        }

        public void add(int val)
        {
            if(root == null)
            {
                root = new Node(val);
            }
            else
            {
                addNode(root, val);
            }
        }
        private void addNode(Node p, int val)
        {
            if(val < p.val)
            {
                if(p.left == null)
                {
                    p.left = new Node(val);
                }
                else
                {
                    addNode(p.left, val);
                }
            }
            else
            {
                if(p.right == null)
                {
                    p.right = new Node(val);
                }
                else
                {
                    addNode(p.right, val);
                }
            }
        } 

        public void print()
        {
            printNode(root);
        }
        private void printNode(Node p)
        {
            if (p == null)
                return;

            printNode(p.left);          // L
            Console.Write(p.val + " "); // V
            printNode(p.right);         // R
        }
    }
}