using System;
using System.Collections.Generic;

namespace Assessed_Exercise_4_Graph
{
    public class Graph<T> where T : IComparable
    {
        // list of all the nodes in the graph.
        private LinkedList<GraphNode<T>> nodes;
        private int counteredges;

        // constructor – set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public void IncomingRemoveEdge(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                n.RemoveEdge(node);
            }
        }

        // only returns true if the graph’s list of nodes is empty
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        // only returns true if the graph’s EDGE is empty
        public bool IsEmptyEdgeGraph()
        {
            return counteredges == 0;
        }
        
        // add a new node (with this “id”) to the list of nodes of the graph
        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public void DeleteNode(T id)
        {
            for (int i = 0; i < GetNodeByID(id).GetAdjList().Count; i++)
            {
                counteredges--;
            }

            foreach (GraphNode<T> l in nodes)
            {
                foreach (T n in l.GetAdjList())
                {
                    if (n.CompareTo(id) == 0)
                    {
                        counteredges--;
                    }
                }
            }
            nodes.Remove(GetNodeByID(id));
        }
        
        // only returns true if node is present in the graph
        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        
        //returns the node with this id
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID)==0) return n;
            }
            return null;
        }
        
        // Directed edge between the node with id "from" and the node with id “to” 
        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null & n2 != null)
            {
                n1.AddEdge(n2);
                counteredges++;
            }
            else
                Console.WriteLine("Node/s not found in the graph. Cannot add the edge");
        }
        public void DisplayExtra(T fromX, T toX)
        {
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|"); 
            Console.WriteLine("|   The following airport has been removed: " + fromX + " and the following route has been removed: " + fromX + " => " + toX); 
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
        }
        
        // only returns true if nodes “from “ and “to” are adjacent
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                    {
                        return true;
                    }

                    return false;
                }
            }
            return false;
        }
        
        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            return nodes.Count;
        }
        
        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {
            return counteredges;
        }

        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();

            toVisit.Enqueue(startID);
            
            while (toVisit.Count != 0)
            {
                T currentID = toVisit.Dequeue();

                visited.Add(currentID);

                GraphNode<T> n1 = GetNodeByID(currentID);
                adj = n1.GetAdjList();

                foreach (T n in adj)
                {
                    if (!visited.Contains(n) && !toVisit.Contains(n))
                    {
                        toVisit.Enqueue(n);
                    }
                }
            }
        }
    }
}