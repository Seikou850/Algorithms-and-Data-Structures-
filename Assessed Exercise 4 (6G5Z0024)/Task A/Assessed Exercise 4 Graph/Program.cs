using System;

namespace Assessed_Exercise_4_Graph
{
    class Program
    {
        public static void Main(string[] args)
        {
            Graph<string> myGraph = new Graph<string>();

            do
            {
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("| How many nodes will you like to add? |");
                Console.WriteLine("|--------------------------------------|");
                Console.Write("Enter here the number of nodes: ");

                int numOfNodes;
                while (!int.TryParse(Console.ReadLine(), out numOfNodes))
                    Console.WriteLine("Try again, insert a NUMBER!!");

                for (int i = 0; i < numOfNodes; i++)
                {
                    int count = i + 1;
                    Console.Write("Insert the node number " + count + " of the graph: ");
                    string wordNode = Console.ReadLine()?.ToUpper();
                    myGraph.AddNode(wordNode);
                }

                Console.WriteLine("");
                Console.Write("Enter the number of connections you would like to add: ");

                int numberOfEdges;
                while (!int.TryParse(Console.ReadLine(), out numberOfEdges))
                    Console.WriteLine("Try again, insert a NUMBER!!");

                for (int i = 1; i < numberOfEdges + 1; i++)
                {
                    Console.WriteLine("|*******************************************|");
                    Console.WriteLine("|     Current number of connections " + i + "/" +
                                      numberOfEdges);
                    Console.WriteLine("|*******************************************|");

                    Console.Write("Please enter the ID of the starting node for the directed edge:  ");
                    string from = Console.ReadLine()?.ToUpper();

                    Console.Write("Which node should the directed edge lead to (enter ID): ");
                    string to = Console.ReadLine()?.ToUpper();

                    myGraph.AddEdge(from, to); // Add connections between the nodes. these are direct edges
                }

                Console.WriteLine("|--------------------------------------------------------------|");
                Console.WriteLine(
                    "|           Current number of NODES in the graph: " + myGraph.NumNodesGraph());
                Console.WriteLine(
                    "|           Current number of EDGES in the graph: " + myGraph.NumEdgesGraph());
                Console.WriteLine("|--------------------------------------------------------------|");
                
                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadKey().KeyChar != 'N');
        }
    }
}