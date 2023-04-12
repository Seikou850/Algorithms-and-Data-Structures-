using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BSTree<string> mytree = new BSTree<string>();
            do
            {
                System.Console.WriteLine("|----------------------------------------------------------|");
                System.Console.WriteLine("|   Type how many words you want to add to the BSTree      |");
                System.Console.WriteLine("|   Hint: the number you enter should be a integer         |");
                System.Console.WriteLine("|----------------------------------------------------------|");
                Console.Write("Type number here: ");

                var numWords = Convert.ToInt32(Console.ReadLine());
                string words;

                for (int i = 0; i < numWords; i++)
                {
                    Console.Write("Add the " + i + " word of the list: ");
                    words = Console.ReadLine();
                    mytree.InsertItem(words);
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
                    string buffer = "";
                    mytree.PreOrder(ref buffer);

                    // display the content of the tree
                    Console.WriteLine("Pre-Order visit of BinTree: " + buffer);
                }
                else if (userChoice == "2")
                {
                    string buffer = "";
                    mytree.InOrder(ref buffer);

                    // display the content of the tree
                    Console.WriteLine("In-order visit of BinTree " + buffer);
                }
                else if (userChoice == "3")
                {
                    string buffer = "";
                    mytree.PostOrder(ref buffer);

                    // display the content of the tree
                    Console.WriteLine("Post-Order visit of BinTree " + buffer);
                }
                else
                {
                    Console.WriteLine("!ERROR! You must type a number between 1 and 3. Try again!!");
                    break;
                }

                mytree.Height(); // Prints the height of the tree

                Console.Write("Type here the word you want to check if it is present on the tree: ");
                string checkWord = Console.ReadLine();

                var present = mytree.Contains(checkWord);
                Console.WriteLine("Item present: " + present);

                mytree.count();

                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadKey().KeyChar != 'N');
        }
    }
}