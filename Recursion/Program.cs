using Recursion.Recursion;

Random rnd = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 1000);
    Console.Write($"{array[i]}, ");
}

Console.WriteLine();
int sum = Recursiоn.Sum(array);
Console.WriteLine(sum);
Console.WriteLine(Recursiоn.GetMax(array));
Console.WriteLine(Recursiоn.Count(array));
Console.WriteLine(Recursiоn.Factorial(10));