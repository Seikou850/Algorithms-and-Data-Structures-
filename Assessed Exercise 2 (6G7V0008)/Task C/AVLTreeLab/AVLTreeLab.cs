using System;
using AVLTreeLab;
using Binary_Search_Tree;

namespace AVLTreeLab
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public int key;

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private Node<T> insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
    
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
            
            if (item.CompareTo(tree.Data) == 0)
            {
                tree.Count++;
            }
            
            tree.BalanceFactor = height(tree.Left) -
                                 height(tree.Right);

            return tree;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree == null || tree.Right == null)
            {
                return; // added null check
            }
            if (tree.Left.BalanceFactor < 0) //double rotate
                rotateLeft(ref tree.Left);

            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;
        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree == null || tree.Left == null)
            {
                return;
            }
            
            if (tree.Right.BalanceFactor > 0) //double rotate
                rotateRight(ref tree.Right);

            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Right;

            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;

            tree = newRoot;
        }

        private int height(Node<T> tree)
        {
            if (tree == null)
                return 0;

            int leftHeight = height(tree.Left);
            int rightHeight = height(tree.Right);

            return Math.Max(leftHeight, rightHeight) + 1;

        }
    }
}