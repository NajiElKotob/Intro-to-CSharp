Console.WriteLine("Starting...");

Task<string> task1 = GetStringAfterDelay("Task 1", 3000);
Task<string> task2 = GetStringAfterDelay("Task 2", 1000);

// Wait for both tasks to complete simultaneously
/**/
string[] results = await Task.WhenAll(task1, task2);
Console.WriteLine(results[0]);
Console.WriteLine(results[1]);


// Wait for both tasks to complete using await
/*
string result1 = await task1;
string result2 = await task2;

Console.WriteLine(result1);
Console.WriteLine(result2);
*/


static async Task<string> GetStringAfterDelay(string taskName, int delay)
{
    Console.WriteLine($"{taskName} started.");
    await Task.Delay(delay);
    Console.WriteLine($"{taskName} completed.");
    return $"{taskName} finished after {delay}ms";
}

