# Graph
A graph is a non-linear data structure that can be looked at as a collection of vertices (or nodes) potentially connected by line segments named edges.

## Challenge
Implement a Graph Class with the following methods:
{AddNode, AddEdge, GetNodes, GetNeighbors and size}

## Approach & Efficiency
- Time complexity for ``AddNode`` and ``Size`` methods are O(1).
- Time complexity for ``AddEdge`` , ``GetNodes`` and ``GetNeighbors`` methods are O(n).

## API
1. add node.<br>
 Arguments: value, Returns: The added node <br>
 Add a node to the graph

2. add edge.<br>
 Arguments: 2 nodes, Returns: nothing <br>
 Adds a new edge between two nodes in the graph <br>
 Both nodes should already be in the Graph

3. get nodes.<br>
 Returns all of the nodes in the graph as a List
 
4. get neighbors.<br>
 Arguments: node <br>
 Returns a List of edges(Nodes) connected to the given node

5. size.<br>
 Returns the total number of nodes in the graph (int)

## Link to [Code](../data-structures-project/Graph.cs)
## Link to [Test](../TestDataStructuresProject/UnitTest1.cs) Line 525