using System.Diagnostics;

var Dict = new Dictionary<uint, string>();
for (uint i = 0; i < 5000000; i++)
    Dict.Add(i, $"Element {i}");
            
uint SearchFor = 4129417;

Stopwatch stopWatch = new Stopwatch();
GC.Collect();
stopWatch.Start();
var d = Dict.ContainsKey(SearchFor);
stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed);
Console.WriteLine(d);