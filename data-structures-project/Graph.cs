using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class Graph
    {
        List<List<Node>> graph = new List<List<Node>>();

        public Node AddNode(string value)
        {
            List<Node> row = new List<Node>();
            Node node = new Node(value);
            row.Add(node);
            graph.Add(row);
            return row.First();
        }

        public void AddEdge(Node node1, Node node2)
        {
            try
            {
                List<Node> firstNodeRow = graph.Find(row => row.First().value == node1.value);
                firstNodeRow.Add(node2);

                List<Node> secondNode = graph.Find(x => x.First().value == node2.value);
                secondNode.Add(node1);
            }
            catch (Exception e)
            {
                throw new Exception("Nodes should be in the Graph (Add the missing Node)" + e.Message);
            }
        }

        public List<Node> GetNodes()
        {
            List<Node> nodes = new List<Node>();

            foreach (List<Node> row in graph)
            {
                nodes.Add(row.First());
            }

            if (nodes.Count == 0)
                return null;

            return nodes;
        }

        public List<Node> GetNeighbors(Node node)
        {
            List<Node> neighbors = new List<Node>();
            try
            {
                List<Node> row = graph.Find(x => x.First().value == node.value);
                foreach (Node neighbor in row)
                {
                    if (neighbor.value != node.value)
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
    }
}
