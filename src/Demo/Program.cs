using Leonardo;


var results = Fibonacci.RunAsync(args);
Console.WriteLine("finished");
results.Wait();