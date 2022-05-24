# Insertion Sort
Insertion sort is a sorting algorithm that places an unsorted element at its suitable place in each iteration.<br>
Insertion sort works similarly as we sort cards in our hand in a card game.<br>
In card games, We assume that the first card is already sorted then, we select an unsorted card. If the unsorted card is greater than the card in hand, it is placed on the right otherwise, to the left. In the same way, other unsorted cards are taken and put in their right place.

## Pseudocode
```csharp
InsertionSort(int[] arr)

    FOR i = 1 to arr.length

      int j <-- i - 1
      int temp <-- arr[i]

      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1

      arr[j + 1] <-- temp
```
## Trace
Sample Array: ``[8,4,23,42,16,15]``

### pase 1:
```
i = 1
j = 0
temp = 4

[8,4,23,42,16,15] --> [4,8,23,42,16,15]
```
If the first element is greater than temp, then temp is placed in front of the first element.

### pase 2:
```
i = 2
j = 1
temp = 23

[4,8,23,42,16,15] --> [4,8,23,42,16,15]
```
While didn't run because ``'temp > arr[j]'`` so nothing change.

### pase 3:
```
i = 3
j = 2
temp = 42

[4,8,23,42,16,15] --> [4,8,23,42,16,15]
```
again nothing change.

### pase 4:
```
i = 4
j = 3
temp = 16

[4,8,23,42,16,15] --> [4,8,23,42,42,15] --> [4,8,23,23,42,15]
go out of while loop

[4,8,23,23,42,15] --> [4,8,16,23,42,15]
```
Place 16 before 23, run while loop two times until ``'temp > arr[j]'`` then place temp in it's correct position.

### pase 5:
```
i = 5
j = 4
temp = 15

[4,8,16,23,42,15] --> [4,8,16,23,42,42] 
--> [4,8,16,23,23,42] --> [4,8,16,16,23,42]
go out of while loop

[4,8,16,16,23,42] --> [4,8,15,16,23,42]
```
Place 15 before 16, run while loop three time until ``'temp > arr[j]'`` then place temp in it's correct position.<br>
after that 'i' will increment to 6, forcing it to break out of the for loop and leaving our array now sorted.

## Efficency
### Time: O(n^2)
We have while loop inside for loop so it's n square.

### Space: O(1)
No additional space is being created. This array is being sorted in place… keeping the space O(1).