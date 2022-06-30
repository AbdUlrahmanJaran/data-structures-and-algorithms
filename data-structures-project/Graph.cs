using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class Graph
    {
        List<List<Edge>> graph = new List<List<Edge>>();
        
        public Node AddNode(string value)
        {
            Node node = new Node(value);
            List<Edge> row = new List<Edge>();
            Edge edge = new Edge(node);
            row.Add(edge);
            graph.Add(row);
            return row.First().Node;
        }

        public void AddEdge(Node node1, Node node2 ,int wight)
        {
            try
            {
                List<Edge> firstNodeRow = graph.Find(row => row.First().Node.value == node1.value);
                firstNodeRow.Add(new Edge(node2, wight));
                
                List<Edge> secondNode = graph.Find(x => x.First().Node.value == node2.value);
                secondNode.Add(new Edge(node1, wight));

            }
            catch (Exception e)
            {
                throw new Exception("Nodes should be in the Graph (Add the missing Node)" + e.Message);
            }
        }

        public List<Node> GetNodes()
        {
            List<Node> nodes = new List<Node>();

            foreach (List<Edge> row in graph)
            {
                nodes.Add(row.First().Node);
            }

            if (nodes.Count == 0)
                return null;

            return nodes;
        }

        public List<Edge> GetNeighbors(Node node)
        {
            List<Edge> neighbors = new List<Edge>();
            try
            {
                List<Edge> row = graph.Find(x => x.First().Node.value == node.value);
                foreach (Edge neighbor in row)
                {
                    if (neighbor.Node.value != node.value)
                    {
                        neighbors.Add(neighbor);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Node should be in the Graph (Add the missing Node)" + e.Message);
            }

            if (neighbors.Count == 0)
                return null;

            return neighbors;
        }

        public int Size()
        {
            return graph.Count;
        }

        public List<Node> BreadthFirst(Node node)
        {
            List<Node> nodes = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            List<Node> visited = new List<Node>();

            breadth.Enqueue(node);
            visited.Add(node);

            while (breadth.Count > 0)
            {
                Node front = breadth.Dequeue();
                nodes.Add(front);
                foreach (Edge neighbor in GetNeighbors(front))
                {
                    if (!visited.Contains(neighbor.Node))
                    {
                        visited.Add(neighbor.Node);
                        breadth.Enqueue(neighbor.Node);
                    }
                }
            }
            return nodes;
        }

        public static string BusinessTrip(Graph graph, string[] cities)
        {
            int result = 0;
            if(graph == null || cities == null)
            {
                return null;
            }
            for (int i = 0; i < cities.Length - 1; i++)
            {
                try
                {
                    Node node = new Node(cities[i]);
                    Node next = new Node(cities[i + 1]);
                    List<Edge> nodeEdges = graph.GetNeighbors(node);
                    
                    result += nodeEdges.Find(e => e.Node.value == next.value).Weight;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return "$"+result;
        }
    }

    public class Edge
    {
        public Node Node { get; set; }
        public int Weight { get; set; }

        public Edge(Node node, int weight)
        {
            Node = node;
            Weight = weight;
        }
        public Edge(Node node)
        {
            Node = node;
        }
    }
}
