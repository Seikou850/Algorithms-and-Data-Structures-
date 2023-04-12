using System;
using System.Collections.Generic;

namespace Assessed_Exercise_4_Graph
{
    class Program
    {
        public static void Main(string[] args)
        {
            Graph<string> myGraph = new Graph<string>();
            List<string> airports = new List<string>();

            try
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine(
                        "|---------------------------------------------------------------------------------------|");
                    Console.WriteLine(
                        "|                          Enter 1 for program instructions.                            |");
                    Console.WriteLine(
                        "|                           * Enter 2 to insert an airport.                             |");
                    Console.WriteLine(
                        "|                          * Enter 3 to insert a connection.                            |");
                    Console.WriteLine(
                        "|       * Enter 4 to display airports that can be reached from the starting airport.    |");
                    Console.WriteLine(
                        "|                          * Enter 5 to delete an airport.                              |");
                    Console.WriteLine(
                        "|    * Enter 6 to display connecting flights FROM the airport you are travelling.       |");
                    Console.WriteLine(
                        "|---------------------------------------------------------------------------------------|");
                    Console.Write("Type number here: ");

                    int userChoice;
                    while (!int.TryParse(Console.ReadLine(), out userChoice))
                        Console.WriteLine("Try again, insert a number from the table!!");

                    if (userChoice == 1)
                    {
                        Console.WriteLine("Instructions");
                        Console.WriteLine(
                            "1.- You have to insert the airports you want to have in your graph, the program will ask you for an exact number of airports you want to have.");
                        Console.WriteLine(
                            "2.- Once you have complete the first instruction, you can insert the connections you want, the program will ask you how many connections you want to insert and you can put the number of connection you would like to have in your graph.");
                        Console.WriteLine(
                            "3.- Once you have complete the second instruction, it will show you the airports that you can reach from the starting airport.");
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("|--------------------------------------------------------|");
                        Console.WriteLine("|      Type the NUMBER of airports you want to add       |");
                        Console.WriteLine("|--------------------------------------------------------|");
                        Console.Write("NUMBER of airports you would like to add: ");

                        int numOfAirports;
                        while (!int.TryParse(Console.ReadLine(), out numOfAirports))
                            Console.WriteLine("Try again, insert a number!!");


                        for (int i = 1; i < numOfAirports + 1; i++)
                        {
                            Console.Write("Type here the airport code " + i + " you want to add: ");
                            string airportCode = Console.ReadLine()?.ToUpper();

                            if (!airports.Contains(airportCode))
                            {
                                myGraph.AddNode(airportCode); // Airport nodes in the graph
                                airports.Add(airportCode);
                            }
                            else if (airports.Contains(airportCode))
                            {
                                Console.WriteLine("Error!! You're already enter this airport: " + airportCode);
                            }
                        }
                    }
                    else if (userChoice == 3)
                    {
                        if (!myGraph.IsEmptyGraph())
                        {
                            Console.Write("NUMBER of connections you would like to connect: ");

                            int numberOfEdges;
                            while (!int.TryParse(Console.ReadLine(), out numberOfEdges))
                                Console.WriteLine("Try again, insert a NUMBER!!");

                            for (int i = 1; i < numberOfEdges + 1; i++)
                            {
                                Console.WriteLine("|*******************************************|");
                                Console.WriteLine("|     Current number of connections " + i + "/" +
                                                  numberOfEdges);
                                Console.WriteLine("|*******************************************|");

                                Console.Write("FROM which airport: ");
                                string from = Console.ReadLine()?.ToUpper();

                                Console.Write("TO which airport: ");
                                string to = Console.ReadLine()?.ToUpper();

                                myGraph.AddEdge(from, to); // Add connections between the nodes. these are direct edges
                                
                                
                            }
                        }
                        else if (myGraph.IsEmptyGraph()) ;
                    }
                    else if (userChoice == 4)
                    {
                        Console.Write("Enter here the airport code where you want to travel from: ");
                        string startingAirport = Console.ReadLine()?.ToUpper();

                        if (airports.Contains(startingAirport))
                        {
                            Console.WriteLine("|--------------------------------------------------------|");
                            Console.Write("  Airports that can be reached from {0}: => ",
                                myGraph.GetNodeByID(startingAirport).ID);
                            Console.WriteLine(myGraph.GetNodeByID(startingAirport).DisplayAdjList());
                            Console.WriteLine("|--------------------------------------------------------|");
                        }
                        else
                        {
                            Console.WriteLine("|--------------------------------------------------------|");
                            Console.WriteLine("|     !!Error!! The airport you typed doesn't exit!      |");
                            Console.WriteLine("|--------------------------------------------------------|");

                        }
                    }
                    else if (userChoice == 5)
                    {
                        Console.Write("Type here the airport you want to remove: ");
                        string airportRemoved = Console.ReadLine()?.ToUpper();

                        if (airports.Contains(airportRemoved))
                        {
                            myGraph.DisplayExtra(airportRemoved, myGraph.GetNodeByID(airportRemoved).DisplayAdjList());
                            myGraph.DeleteNode(airportRemoved);
                            myGraph.IncomingRemoveEdge(new GraphNode<string>(airportRemoved));
                            airports.Remove(airportRemoved);
                        }
                        else
                        {
                            Console.WriteLine("|--------------------------------------------------------|");
                            Console.WriteLine("|     !!Error!! The airport you typed doesn't exit!!    |");
                            Console.WriteLine("|--------------------------------------------------------|");
                        }
                    }
                    else if (userChoice == 6)
                    {
                        if (myGraph.IsEmptyEdgeGraph())
                        {
                            Console.WriteLine("No Edges were found on the graph");
                        }
                        else
                        {
                            Console.Write("Please, From which airport are travelling?: ");
                            string fromAirport = Console.ReadLine()?.ToUpper();

                            List<string> buffer = new List<string>();
                            myGraph.BreadthFirstTraverse(fromAirport, ref buffer);

                            if (fromAirport != null && buffer.Contains(fromAirport))
                            {
                                int index = buffer.IndexOf(fromAirport);
                                buffer.RemoveAt(index);
                            }

                            string result = "";

                            foreach (var n in buffer)
                            {
                                result += n + ",";
                            }

                            result = result.TrimEnd(',', ' ');
                            // result = result.Replace(fromAirport + ",", "");

                            Console.WriteLine("From " + fromAirport + " you have connecting flights to => " + result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!! " + userChoice + " is NOT initial table.");
                        return;
                    }

                    if (!myGraph.IsEmptyGraph())
                    {

                        Console.WriteLine("|--------------------------------------------------------------|");
                        Console.WriteLine(
                            "|        Current number of Airports in the graph: " + myGraph.NumNodesGraph());
                        Console.WriteLine(
                            "|        Current number of Connection in the graph: " + myGraph.NumEdgesGraph());
                        Console.WriteLine("|--------------------------------------------------------------|");

                    }

                    Console.WriteLine("Do you want to continue (Y/N)? ");
                } while (Console.ReadKey().KeyChar != 'N');
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}