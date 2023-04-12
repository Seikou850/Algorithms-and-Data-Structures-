using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Assessed_Exercise_1
{
    public class Book : IComparable
    { 
        private string title; 
        private string author;
        private int ISBN;
        public Book(string title, string author, int ISBN) // Constructor
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public string Title 
        {
            set { title = value; } 
            get { return this.title; } 
        }

        public string Author
        {
            set { author = value; }
            get { return author; }
        }

        public int isbn
        {
            set { ISBN = value; }
            get { return ISBN; }

        }

        override

        public string ToString() 
        {
            return $"{title} {author} {ISBN} \n" ;
        }
        
        public int CompareTo(Object obj) 
        {
            Book other = (Book)obj;
            return ISBN.CompareTo(other.ISBN);
        }
    }
}
