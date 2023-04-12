using System;

namespace Binary_Search_Tree
{
    class Node<T>
    {
        private T _data;
        public Node<T> Left, Right;
        private int _balaceFactor = 0;
        public int Count =+ 0;
        public int BalanceFactor
        {
            get { return _balaceFactor; }
            set { _balaceFactor = value; }
        }
        public Node(T item)
        {
            _data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { _data = value; }
            get { return _data; }
        }
    }
}