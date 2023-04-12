using System;

namespace Binary_Search_Tree
{
    class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> Left, Right;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

    }
}