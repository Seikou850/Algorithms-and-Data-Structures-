using System;

namespace Task_A_and_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[11]
            {
                "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", ""
            };

            System.Console.WriteLine("|---------------------------------------------------------|");
            System.Console.WriteLine("|      Type from 1 to 10 the words you want to add.       |");
            System.Console.WriteLine("|---------------------------------------------------------|");
            Console.Write("Type number here: ");

            int numWords = Convert.ToInt32(Console.ReadLine());

            if (numWords > 10)
            {
                Console.WriteLine("Sorry you're only allow to enter 10 words. Try again!!");
                return;
            }

            Queue myQueue = new Queue(numWords);
            string[] w = new string[numWords];

            for (int i = 0; i < numWords; i++)
            {
                Console.Write("Add the " + words[i] + " word of the list: ");

                w[i] = Console.ReadLine();
                myQueue.Enqueue(w[i]);
            }

            do
            {
                Console.WriteLine("");
                System.Console.WriteLine("|-----------------------------------|");
                System.Console.WriteLine("| Type 2 to Remove items            |");
                System.Console.WriteLine("| Type 3 to display the queue       |");
                System.Console.WriteLine("| Type 4 to reverse K items         |");
                System.Console.WriteLine("| Type 5 to count the items         |");
                System.Console.WriteLine("|-----------------------------------|");
                Console.Write("Type number here: ");

                string userChoice = Console.ReadLine();
                if (userChoice == "2")
                {
                    System.Console.WriteLine("Removed: " + myQueue.Dequeue());
                }

                if (userChoice == "3")
                {
                    Console.Write("Items in the queue: ");
                    myQueue.display();
                }

                if (userChoice == "4")
                {
                    Console.Write("Type how many items would you like to reverse: ");
                    int reverse = Convert.ToInt32(Console.ReadLine());
                    myQueue.reverseK(reverse - 1);
                    Console.Write("The following words have been reversed: ");
                    myQueue.display();
                }

                if (userChoice == "5")
                {
                    Console.WriteLine("Total number of words in the queue is: " + myQueue.actualSize());
                }

                Console.WriteLine("");
                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadKey().KeyChar != 'N');
        }
    }
}

