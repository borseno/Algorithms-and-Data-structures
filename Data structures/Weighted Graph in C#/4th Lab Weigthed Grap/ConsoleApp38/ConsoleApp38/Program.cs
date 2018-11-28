using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;

namespace DST_Lab4_s
{
    public class Node<T>
    {
        private T Data;
        public NodeList<T> neighbors = null;

        public Node() { }

        public Node(T value)
        {
            Value = value;
        }
        
        public Node(T value, NodeList<T> neighbors)
        {
            this.neighbors = neighbors;
            this.Data = value;
        }

        public T Value
        {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
            }
        }

        protected NodeList<T> Neighbors
        {
            get
            {
                return neighbors;
            }
            set
            {
                neighbors = value;
            }
        }   
    }

    public class GraphNode<T> : Node<T>
    {
        public List<int> costs;

        public GraphNode() : base() { }
        public GraphNode(T value) : base(value) { }
        public GraphNode(T value, NodeList<T> neighbors) : base(value, neighbors) { }

        new public NodeList<T> Neighbors
        {
            get
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>();

                return base.Neighbors;
            }
        }

        public List<int> Costs
        {
            get
            {
                if (costs == null)
                    costs = new List<int>();

                return costs;
            }
            set
            {
                costs = value;
            }
        }
    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (int i = 0; i < initialSize; i++)
                base.Items.Add(default(Node<T>));
        }

        public Node<T> FindByValue(T value)
        {
            // search the list for the value
            foreach (Node<T> node in Items)
                if (node.Value.Equals(value))
                    return node;

            // if we reached here, we didn't find a matching node
            return null;
        }

    }

    public class Graph<T> : IEnumerable<T>
    {
        private NodeList<T> nodeSet;

        public Graph() : this(null) { }
        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new NodeList<T>();
            else
                this.nodeSet = nodeSet;
        }

        public void AddNode(GraphNode<T> node)
        {
            // adds a node to the graph
            nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            // adds a node to the graph
            nodeSet.Add(new GraphNode<T>(value));
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost = -1)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddDirectedEdge(T from, T to, int cost = -1)
        {
            nodeSet.FindByValue(from).neighbors.Add(nodeSet.FindByValue(to));
            GraphNode<T> s = (GraphNode<T>)nodeSet.FindByValue(from);
            s.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);

            to.Neighbors.Add(from);
            to.Costs.Add(cost);
        }

        public bool Contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            // first remove the node from the nodeset
            GraphNode<T> nodeToRemove = (GraphNode<T>)nodeSet.FindByValue(value);
            if (nodeToRemove == null)
                // node wasn't found
                return false;

            // otherwise, the node was found
            nodeSet.Remove(nodeToRemove);

            // enumerate through each node in the nodeSet, removing edges to this node
            foreach (GraphNode<T> gnode in nodeSet)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    // remove the reference to the node and associated cost
                    gnode.Neighbors.RemoveAt(index);
                    gnode.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public List<Node<T>> DFS(Node<T> start)
        {
            List<Node<T>> visited = new List<Node<T>>();
            
            if (!this.nodeSet.Contains(start))
            {
                return visited;
            }

            var stack = new Stack<Node<T>>();

            stack.Push(start);
            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach(var neighbor in nodeSet.FindByValue(vertex.Value).neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }
            return visited;

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public NodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }
    }   

    public class Program
    {
        public void Main(string[] args)
        {
            Graph<string> web = new Graph<string>();
            web.AddNode("Privacy.htm");
            web.AddNode("People.aspx");
            web.AddNode("About.htm");
            web.AddNode("Index.htm");
            web.AddNode("Products.aspx");
            web.AddNode("Contact.aspx");

            web.AddDirectedEdge("People.aspx", "Privacy.htm");
            web.AddDirectedEdge("Privacy.htm", "Index.htm");    // Privacy -> Index
            web.AddDirectedEdge("Privacy.htm", "About.htm");    // Privacy -> About

            web.AddDirectedEdge("About.htm", "Privacy.htm");    // About -> Privacy
            web.AddDirectedEdge("About.htm", "People.aspx");    // About -> People
            web.AddDirectedEdge("About.htm", "Contact.aspx");   // About -> Contact

            web.AddDirectedEdge("Index.htm", "About.htm");      // Index -> About
            web.AddDirectedEdge("Index.htm", "Contact.aspx");   // Index -> Contacts
            web.AddDirectedEdge("Index.htm", "Products.aspx");  // Index -> Products

            web.AddDirectedEdge("Products.aspx", "Index.htm");  // Products -> Index
            web.AddDirectedEdge("Products.aspx", "People.aspx");// Products -> People

            DST_Lab4_s.Node<string> a = new Node<string>("Products.aspx");
            List<Node<string>> A = web.DFS(a);
            foreach (var i in A)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}