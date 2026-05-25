using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "Task-5/input.txt";
        string outputFilePath = "result.txt";

        try
        {
            // Read all text from file
            string content = File.ReadAllText(inputFilePath);

            // Process data
            int lineCount = File.ReadAllLines(inputFilePath).Length;
            int wordCount = content.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            ).Length;

            // Prepare result
            string result =
                $"Lines: {lineCount}\n" +
                $"Words: {wordCount}";

            // Write to output file
            File.WriteAllText(outputFilePath, result);

            Console.WriteLine("File processed successfully!");
            Console.WriteLine("Result written to result.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Input file not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/O error occurred:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error:");
            Console.WriteLine(ex.Message);
        }
    }
}