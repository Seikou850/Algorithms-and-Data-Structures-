using System;

namespace Selection_Sort
{
    class Program
    {
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static public void SelecSortGen<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
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

        public static void Main(string[] args)
        {
            Console.WriteLine("|-------------------------------------| ");
            Console.WriteLine("|How many names you would like to add?| ");
            Console.WriteLine("|-------------------------------------|");
            Console.Write("Enter here the name: ");

            int iteration;
            while (!int.TryParse(Console.ReadLine(), out iteration))
                Console.WriteLine("Try again, insert a number!!");

            Student[] students = new Student[iteration];
            Random rnd = new Random();


            for (int i = 0; i < iteration; i++)
            {
                int studentNO = i + 1; 
                Console.Write("Enter the student number " + studentNO + " name: ");
                var names = Console.ReadLine();

                int age = +rnd.Next(18, 25);
                students[i] = new Student(names, age);
            }

            Console.WriteLine("");
            Console.WriteLine("The following students have been sorted in order by their age:");
            SelecSortGen(students);

            foreach (var n in students)
            {
                Console.WriteLine(n);
            }
        }
    }
}