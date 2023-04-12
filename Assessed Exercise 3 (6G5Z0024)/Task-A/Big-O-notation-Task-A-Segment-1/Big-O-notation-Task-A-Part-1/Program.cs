using System;

namespace Big_O_notation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input n"); // O(1) - Constant time complexity will always take same amount of time to be executed. 
            int n = Convert.ToInt32(Console.ReadLine());  // O(1) - Constant time complexity, it will ask the user to input a number once.
            
            int r = 20; // O(1) - Constant time complexity will always take same amount of time to be executed. 
            int dummy = 0; // O(1) - Constant time complexity.

            Console.WriteLine("Creating a nested loop"); //O(1) - Constant time complexity, it will only output once in each program execution. 

            for (int i = 0; i < n; i++) //Outer loop [n+1] || this loop will loop n times, and every time it loops n will increase by one
            // also i will increase by one as longest n keeps increasing.
            {
                Console.WriteLine("Inside the first loop"); //O(n) - each time the first for loop loops it will print 
                //this statement.

                dummy++; // 0(n), dummy will increase by one each n loop.

                for (int j = 0; j < n; j++) //Inner loop n(n+1), this second for loop will increase by one each inner loop after the outer loop.
                {

                    r = r + dummy; //n*n, r is a constant which means that it doesn't change it will be 20 always, dummy will be 
                    //loped n times and it will increase each time by one, and that will make r to move-up by one each time dummy increase..
                    Console.WriteLine("Inside the second loop " + r); //n*n - Constant time complexity

                  //The Big O notation for this algorithm is: Big O = O(n2)
                }

            } 

        }
    }
}