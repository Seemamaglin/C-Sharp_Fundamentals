using System;

// Define a delegate
public delegate void ThresholdReachedHandler(int currentValue);

//  Create a Counter class (Event Producer)
public class Counter
{
    private int _count;
    private readonly int _threshold;

    // : Define an event using the delegate
    public event ThresholdReachedHandler ThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
        _count = 0;
    }

    public void Increment()
    {
        _count++;
        Console.WriteLine($"Counter value: {_count}");

        // Step 4: Raise event when condition is met
        if (_count == _threshold)
        {
            OnThresholdReached();
        }
    }

    protected void OnThresholdReached()
    {
        // Invoke event safely
        ThresholdReached?.Invoke(_count);
    }
}

// Consumer class with event handlers
public class EventActions
{
    public void ShowMessage(int value)
    {
        Console.WriteLine($"⚠ Threshold reached at {value}");
    }

    public void LogToConsole(int value)
    {
        Console.WriteLine($"[LOG] Counter hit the limit: {value}");
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter(threshold: 5);
        EventActions actions = new EventActions();

        counter.ThresholdReached += actions.ShowMessage;
        counter.ThresholdReached += actions.LogToConsole;

        for (int i = 0; i < 7; i++)
        {
            counter.Increment();
            System.Threading.Thread.Sleep(500);
        }

        Console.WriteLine("Program finished.");
    }
}