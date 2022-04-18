using SortAlgorithms.Sort;


int[] array = new int[50000000];
for (int i = 0; i < array.Length; i++)
    array[i] = i;
array = SelectionSort.Sort(array);

for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}, ");