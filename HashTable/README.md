# Hashtables
Hashtables are a data structure that utilize key value pairs. This means every Node or Bucket has both a key, and a value.

## Challenge
Implement a Hashtable Class with the following methods:
{Set, Get, Contains, Keys and Hash}

## Approach & Efficiency
time complexity
Average Case is O(1)
Worst Case is O(n)

## API
1. ``Set`` take key and value as strings.
2. ``Get`` take a key as string and return a value associated with that key in the table 
3. ``Contains`` take a key as string and check if this value exist in the HashTable or not.
4. ``Keys`` return a List of all the keys inside a HashTable.
5. ``Hash`` take a key as string and convert it to index in the HashTable.

## Link to [Code](../data-structures-project/HashTable.cs)
## Link to [Test](../TestDataStructuresProject/UnitTest1.cs) Line 300