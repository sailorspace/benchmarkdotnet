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