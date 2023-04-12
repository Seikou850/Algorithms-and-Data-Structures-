using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Assessed_Exercise_1
{
    public class GenericList<T> where T : IComparable
    {
        private Linked_List<T> list;
        int plus = 0;

        public void AddItem(T item)
        {
            Linked_List<T> NewLink = new Linked_List<T>(item);

            NewLink.Data = item;
            NewLink.Next = list;
            list = NewLink;
            plus++;
        }

        public void AppendItem(T item)
        {
            plus++;

            Linked_List<T> temp = list;

            if (temp == null)
            {
                list = new Linked_List<T>(item);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Linked_List<T>(item);
            }
        }

        public void RemoveItem(T item)
        {
            plus--;
            Linked_List<T> temp = list;

            GenericList<T> newList = new GenericList<T>();

            while (temp != null)
            {
                if (item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);
                }
                temp = temp.Next;
            }
            list = newList.list;

        }


        public void SelecSortGen<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest]) == -1)
                        smallest = j;
                }

                swap(ref a[i], ref a[smallest]);
            }
        }

        static public void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        public string InsertInOrder()
        {
            Linked_List<T> temp = list;
            int count = 0;
            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }
            T[] arr = new T[count];

            temp = list;
            int i = 0;

            while (temp != null)
            {
                arr[i] = temp.Data;
                temp = temp.Next;
                i++;
            }

            SelecSortGen(arr);

            string buffer = ",";

            foreach (var n in arr)
            {
                buffer += n;
            }

            return buffer;
        }


        public string Display()
        {
            return InsertInOrder();
        }


        public bool IsPresentItem(T item)
        {
            Linked_List<T> temp = list;
            string buffer = "";

            T data;

            while (temp != null)
            {
                data = temp.Data;
                buffer += data.ToString();
                temp = temp.Next;

                if (data.Equals(item))
                {
                    return true;
                }

            }
            return false;

        }
        public int numberOfbooks()
        {
            return plus;
        }
        public string DisplayList()
        {
            Linked_List<T> temp = list;
            string buffer = " ";

            while (temp != null)
            {
                buffer += temp.Data.ToString();
                temp = temp.Next;
            }
            return buffer;
        }

    }
}