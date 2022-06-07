# Merge Sort
Merge sort is a sorting algorithm based on the Divide and conquer strategy. It works by recursively dividing the array into two halves, then sort them and combine them.

## Pseudocode
```csharp
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length

    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1

        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```
## Trace
Sample Array: ``[8,4,23,42,16,15]``

### pase 1:
```csharp
mid = 2
left = [8,4,23]
right = [42,16,15]
```
![Pase 1](./pase1.jpg)
Find the middle index of the array and Divide the array from the middle.

### pase 2:
![Pase 2](./pase2.jpg)
Call merge sort for each half two times.

### pase 3:
![Pase 3](./pase3.jpg)
Sort and merge by Merge function.

### pase 4:
![Pase 4](./pase4.jpg)
Merge the two sorted halves into a single sorted array.

## Efficency
### Time: O(n logn)

### Space: O(n)