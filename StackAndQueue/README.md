# Stacks and Queues
Stack is a data structure that follow FILO (First In Last Out) & LIFO (Last In First Out) concepts.<br>
Queue is a data structure that  follow FIFO (First In First Out) & LILO (Last In Last Out) concepts.

## Challenge
Implement both a Stack and a Queue with these Methods: push, pop, peek and is empty for the Stack and enqueue, dequeue, peek and is empty for the Queue.

## Approach & Efficiency
All the Methods Time complexity is Big O(1), This is because they take the same amount of time no matter how many Nodes (n) you have.

## API
### Stack Methods:
- Push - Nodes or items that are put into the stack are pushed
- Pop - Nodes or items that are removed from the stack are popped. When you attempt to pop an empty stack an exception will be raised.
- Peek - When you peek you will view the value of the top Node in the stack. When you attempt to peek an empty stack an exception will be raised.
- IsEmpty - returns true when stack is empty otherwise returns false.

### Queue Methods:
- Enqueue - Nodes or items that are added to the queue.
- Dequeue - Nodes or items that are removed from the queue. If called when the queue is empty an exception will be raised.
- Peek - When you peek you will view the value of the front Node in the queue. If called when the queue is empty an exception will be raised.
- IsEmpty - returns true when queue is empty otherwise returns false.

## Link to Code: [Stack Class](../data-structures-project/Stack.cs), [Queue Class](../data-structures-project/Queue.cs)