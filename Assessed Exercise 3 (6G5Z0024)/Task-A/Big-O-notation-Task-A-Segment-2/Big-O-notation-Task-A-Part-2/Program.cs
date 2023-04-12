using System;

namespace Big_O_notation_Task_A_Part_2
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input m "); // O(1) - Constant time complexity will always take same amount of time to be executed. 
            int m = Convert.ToInt32(Console.ReadLine()); // O(1) - Constant

            for (int j = 1; j <= m; j++) // for loop 0(m), the loop will be loped m times, the plus one is 
            //because the for loop will be loped once to check if the condition is true.
            {

                Console.WriteLine("for loop"); // O(m) - Constant time complexity, it will output the text m times.

            } // end of the loop

            while (m > 0) //0(m) while m is bigger than 0 while loop will loop until the condition is false,
                          //which also translates to m being 0. We can convert the while loop in a for loop
                          // to calculate the Big O notation.
            {
                m--; //each time it loops (m - 1)
                Console.WriteLine("while loop"); // O(m) - Constant, each time it loops print this statement.
            }
            
            //The Big O notation for this algorithm is: Big O = O(n)

        }
    }
}