using System.Diagnostics;

//00:00:00.1049633 Default LINQ               | Find List
//00:00:00.0000579 Default LINQ Binary Search | List
//00:00:00.0000184 Binary Search              | List
//00:00:00.0000055 Binary Search              | Array
//hh:mm:ss.mmmtttt

int[] array = new int[50000000];
for (int i = 0; i < array.Length; i++)
    array[i] = i;
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
int Index = 0;
int search = 41512346;


int low = 0;
int high = array.Length - 1;
while (low <= high)
{
    int mid = (low + high) / 2;
    if (array[mid] == search)
    {
        Index = mid;
        break;
    }
    if (array[mid] > search)
        high = mid - 1;
    else
        low = mid + 1;
}
stopWatch.Stop();

if (Index != 0)
    Console.WriteLine(Index);
else
    Console.WriteLine("There is no such element");

Console.WriteLine(stopWatch.Elapsed);
Console.WriteLine(stopWatch.ElapsedMilliseconds);
Console.WriteLine(stopWatch.ElapsedTicks);