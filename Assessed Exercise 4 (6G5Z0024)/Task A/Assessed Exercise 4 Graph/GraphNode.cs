using System.Collections.Generic;

namespace Assessed_Exercise_4_Graph
{
    public class GraphNode<T>
    {
        private T id; // data stored in the node (“id” of the node).
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
            set { id = value; }
            get { return id; }
        }
        
        // directed edge from “this” node to the node "to”
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }
        
        // returns the adjacent list of the node
        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }


    }
}