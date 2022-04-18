using Sort.Sort;
using System.Diagnostics;

// Seems like it's either me stupid or this "QuickSort" is actually A LOOOT slower than usual selection sort...
// Maybe I use it the wrong way or smthing else. I Don't know
// My opinion is that list and linq and other stuff is kinda slow as hell in this situation and it's really pretty bad
// And it also gives strange results.. And yes - this is official code from book.

Random rnd = new Random();
int[] array = new int[10000];
for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(-100,100);
IEnumerable<int> arr = array.Select(p=>p);
List<int> list = array.ToList();


Stopwatch stopWatch = new Stopwatch();
GC.Collect();
stopWatch.Start();
array = SelectionSort.Sort(array);
stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed);

Stopwatch stopWatch1 = new Stopwatch();
GC.Collect();
stopWatch1.Start();
arr = QuickSort.QSort(arr);
stopWatch1.Stop();
Console.WriteLine(stopWatch1.Elapsed);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}, ");
Console.WriteLine();
arr.ToList().ForEach(i => Console.Write("{0}\t", i));