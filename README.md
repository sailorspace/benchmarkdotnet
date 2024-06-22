# benchmarkdotnet or NBench use any

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
You can use the following code snippet to run benchmarking on a specific type:
var summary = BenchmarkRunner.Run<BenchmarkLINQPerformance>();
Or you can use:
var summary = BenchmarkRunner.Run(typeof(BenchmarkLINQPerformance));

for the NBench tool the call would be a bit different 
like  return NBenchRunner.Run<Program>();

to Test finally run the below:- 
 dotnet run -c Release


e.g test with span<T> vs normal string manupulation results in

| Method         | Mean      | Error     | StdDev    |
|--------------- |----------:|----------:|----------:|
| TestWithSpan   |  4.500 ns | 0.0432 ns | 0.0424 ns |
| RunWithoutSpan | 23.847 ns | 0.1647 ns | 0.1375 ns |