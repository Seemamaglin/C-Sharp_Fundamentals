using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching data started...\n");

        Task<string>[] tasks =
        {
            FetchDataAsync("Source 1", 2000, false),
            FetchDataAsync("Source 2", 3000, false),
            FetchDataAsync("Source 3", 1000, true),
            FetchDataAsync("Source 4", 1500, false)
        };

        try
        {
            string[] results = await Task.WhenAll(tasks);

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }

        Console.WriteLine("\nProgram finished.");
    }

    static async Task<string> FetchDataAsync(string sourceName, int delay, bool shouldFail)
    {
        await Task.Delay(delay);

        if (shouldFail)
        {
            throw new Exception($"{sourceName} failed");
        }

        return $"{sourceName} data fetched successfully";
    }
}