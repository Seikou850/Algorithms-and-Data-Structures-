using System;

namespace Selection_Sort
{
    public class Student : IComparable
    {
        private string _name;
        private int _age;

        //constructor 
        public Student(string Name, int Age)
        {
            _name = Name;
            _age = Age;
        }

     public override string ToString()
     {
         string tostring = "";
         
         Console.WriteLine("|-------------------------------------| ");
         tostring += "       Name: " + _name + " => " + "Age: " + _age;
         return tostring;
     }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
   

        public int CompareTo(Object obj)
        {
            Student other = (Student)obj;
            return age.CompareTo(other.age);
        }

    }
}