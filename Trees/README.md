# Trees
Common Terminology:
Node - A Tree node is a component which may contain its own values, and references to other nodes
Root - The root is the node at the beginning of the tree
Left - A reference to one child node, in a binary tree
Right - A reference to the other child node, in a binary tree

## Challenge
1. Create a Node class.
2. Create a Binary Tree class with methods for ``PreOrder``, ``InOrder`` and ``PostOrder`` traversals.
3. Create a Binary Search Tree class with methods for ``Add`` to add nodes to a tree and ``Contains`` to insure if tree have this value or not.

## Approach & Efficiency
``PreOrder``, ``InOrder`` and ``PostOrder`` methods time complexity is O(n).<br>

``Add`` and ``Contains`` time complexity is also O(n).

## API
1. ``PreOrder`` take a Tree and return a List ordered as Pre Order (Root Left Right).
2. ``InOrder`` take a Tree and return a List ordered as In Order (Left Root Right).
3. ``PostOrder`` take a Tree and return a List ordered as Post Order (Left Right Root).
4. ``Add`` take a Node and add it to a Binary Search Tree in the correct location.
5. ``Contains`` take a value and check if this value exist in the tree at least once or not.

## Link to [Code](./Trees/BinaryTree.cs)