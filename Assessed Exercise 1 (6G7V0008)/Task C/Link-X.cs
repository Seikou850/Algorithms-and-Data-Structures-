using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Assessed_Exercise_1
{
    public class Linked_List <T> 
    {
        private T data; 
        private Linked_List<T> next;

        public Linked_List() {}

        public Linked_List (T item)
        {
            data = item;
            next = null;
        }
        
        public Linked_List(T item, Linked_List<T> list) 
        {
            data = item;
            next = list;
        }
        public Linked_List<T> Next   
        {
            set { next = value; }
            get { return next; }
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

    }
}
