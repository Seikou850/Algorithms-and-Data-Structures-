using System;
using System.Collections.Generic;

namespace Assessed_Exercise_4_Graph
{
    public class GraphNode<T> where T : IComparable
    {
        private T id; // data stored in the node (“id” of the  node).
        private LinkedList<T> adjList; // adjacency list of the node
        
        // constructor 
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }
        
        // set and get the data stored in the node 
        public T ID
        {
            get { return id; }
            set { id = value; }
        }

        // directed edge from “this” node to the node "to”
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }

        public void RemoveEdge(GraphNode<T> to)
        {
            adjList.Remove(to.ID);
        }

        // returns the adjacent list of the node
        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }
        public string DisplayAdjList()
        {
            string result = "";

            foreach (var n in adjList)
            {
                result += n + ",";
            }
            result = result.TrimEnd(',',' ');
            return result;
        }

        public override string ToString()
        {
            return $"{id} \n";
        }
    }
}