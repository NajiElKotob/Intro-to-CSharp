Console.WriteLine("Sync Starting...");

string task1 = GetStringAfterDelay("Task 1", 3000);
string task2 = GetStringAfterDelay("Task 2", 1000);

Console.WriteLine(task1);
Console.WriteLine(task2);


static string GetStringAfterDelay(string taskName, int delay)
{
    Console.WriteLine($"{taskName} started.");

    Task.Delay(delay); // This will cause a 2-second pause before executing the next line.

    Console.WriteLine($"{taskName} completed.");
    return $"{taskName} finished after {delay}ms";
}


// ============================================================


Console.WriteLine("Async Starting...");

Task<string> taskAsync1 = GetStringAfterDelayAsync("Task 1", 3000);
Task<string> taskAsync2 = GetStringAfterDelayAsync("Task 2", 1000);

// Wait for both tasks to complete simultaneously
string[] resultsAsync = await Task.WhenAll(taskAsync1, taskAsync2);
Console.WriteLine(resultsAsync[0]);
Console.WriteLine(resultsAsync[1]);

static async Task<string> GetStringAfterDelayAsync(string taskName, int delay)
{
    Console.WriteLine($"{taskName} started.");

    //Task.Delay(delay); // This won't cause any delay in the next line's execution.
    await Task.Delay(delay); // This will cause a 2-second pause before executing the next line.

    Console.WriteLine($"{taskName} completed.");
    return $"{taskName} finished after {delay}ms";
}

