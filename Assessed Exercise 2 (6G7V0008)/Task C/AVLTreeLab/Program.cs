using System;
using System.Collections.Generic;
using Binary_Search_Tree;

namespace AVLTreeLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> words = new List<string>();
            AVLTree<string> tree = new AVLTree<string>();

            do
            {
                Console.WriteLine("");
                System.Console.WriteLine("|---------------------------------------------------------|");
                System.Console.WriteLine("|   Type how many words you want to add to the AVL Tree   |");
                System.Console.WriteLine("|---------------------------------------------------------|");
                Console.Write("Type number here: ");

                string buffer = "";
                
                int numWords;
                while (!int.TryParse(Console.ReadLine(), out numWords))
                    Console.WriteLine("Try again, insert a NUMBER!!");

                for (int i = 0; i < numWords; i++)
                {
                    Console.Write("Add the " + i + " word of the list: ");
                    
                    string w = Console.ReadLine();
                    tree.InsertItem(w);
                }

                System.Console.WriteLine("|------------------------------------------------|");
                System.Console.WriteLine("| Type 1 for Pre-Order                           |");
                System.Console.WriteLine("| Type 2 for In-Order                            |");
                System.Console.WriteLine("| Type 3 for Post-Order                          |");
                System.Console.WriteLine("|------------------------------------------------|");
                Console.Write("Type number here: ");

                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    tree.PreOrder(ref buffer);
                    Console.WriteLine("Pre-Order AVL Tree: ");
                    Console.WriteLine(buffer);
                }
                else if (userChoice == "2")
                {
                    tree.InOrder(ref buffer);
                    Console.WriteLine("In-Order AVL Tree: ");
                    Console.WriteLine(buffer);
                }
                else if (userChoice == "3")
                {
                    tree.PostOrder(ref buffer);
                    Console.WriteLine("Post-Order AVL Tree: ");
                    Console.WriteLine(buffer);
                }
                else
                {
                    Console.WriteLine("!ERROR! You must type a number between 1 and 3. Try again!!");
                    break;
                }

                tree.Height(); // Prints the height of the tree

                Console.Write("Type here the word you want to check if it is present on the tree: ");
                string checkWord = Console.ReadLine();

                Console.Write("Item present? ");
                var present = tree.Contains(checkWord);
                Console.WriteLine(present);


                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadKey().KeyChar != 'N');
        }
    }
}
