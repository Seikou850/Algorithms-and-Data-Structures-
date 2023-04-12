using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_C_Assessed_Exercise_3
{
    class Program
    {
        static public void SelecSortGen<T>(List<T> a) where T : IComparable
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[j].CompareTo(a[smallest]) == -1)
                        smallest = j;
                }
                
                T temp = a[i];
                a[i] = a[smallest];
                a[smallest] = temp;
            }
        }

        public static void Main(string[] args)
        {

            System.Console.WriteLine("|------------------------------|");
            System.Console.WriteLine("|   Press K to add a request   |");
            System.Console.WriteLine("|------------------------------|");
            Console.Write("Type K here: ");
            
            string userChoice = Console.ReadLine();
            int UniqueID = 1;

            List<Request> r = new List<Request>();
            List<Request> s = new List<Request>();

            
            bool stop = false;
            while (!stop)
            {
                if (userChoice == "K")
                {
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|            Type starting time please!          |");
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|  Hint: enter the time in the following format: |");
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|                12:00AM => 12.00                |");
                    System.Console.WriteLine("|------------------------------------------------|");
                    Console.Write("Type number here: ");
                
                    double starting = Convert.ToDouble(Console.ReadLine());
                
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|          Type finishing time please!           |");
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|  Hint: enter the time in the following format: |");
                    System.Console.WriteLine("|------------------------------------------------|");
                    System.Console.WriteLine("|                12:00AM => 12.00                |");
                    System.Console.WriteLine("|------------------------------------------------|");


                    Console.Write("Type number here: ");
                
                    double finishing = Convert.ToDouble(Console.ReadLine());

                    int k = 1;

                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine("Your unique ID is: " + UniqueID);
                        r.Add(new Request(UniqueID, starting, finishing));
                    }
                    UniqueID++;

                    Console.WriteLine("|------------------------------------------------------------|");
                    Console.WriteLine("|  Press K to to output the largest possible set of requests |");
                    Console.WriteLine("|                          OR                                |");
                    Console.WriteLine("|          Type any other key to add a new request           |");
                    Console.WriteLine("|------------------------------------------------------------|");
                    Console.Write("Type here please: ");
                    
                    
                    string choice = Console.ReadLine();
                    if (choice == "K")
                    {
                        stop = true;
                    }
                }
                
                else
                {
                    Console.WriteLine("Sorry, you need to enter |K| to add a request. Try again!!");
                    return;
                }
            }

            while (stop)
            {
                {
                    SelecSortGen(r);

                    for (int i = 0; i < r.Count; i++)
                    {
                        if (s.Count == 0)
                        {
                            s.Add(r[i]);
                            Console.WriteLine("ID:" + r[i].ToString());
                        }
                        else if (r[i].Starting >= s[s.Count-1].Finishing)
                        {
                            s.Add(r[i]);
                            Console.WriteLine("ID:" + r[i].ToString());
                        }
                    }

                    Console.WriteLine("Largest possible set of requests that can be satisfied is: " + s.Count);
                }
                stop = false;
            }
        }

    }
}