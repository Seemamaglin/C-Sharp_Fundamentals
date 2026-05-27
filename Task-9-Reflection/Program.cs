using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method)]
public class RunnableAttribute : Attribute
{
}

public class MathTasks
{
    [Runnable]
    public void Add()
    {
        Console.WriteLine("Addition: 5 + 3=" + (5 + 3));
    }

    public void Subtract()
    {
        Console.WriteLine("Subtraction: 5 - 3 = "+(5 - 3));
    }
}

public class MessageTasks
{
    [Runnable]
    public void Greet()
    {
        Console.WriteLine("End of MessageTasks!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Discovering runnable methods...\n");

        // Get current assembly
        Assembly assembly = Assembly.GetExecutingAssembly();

        // Scan all types (classes)
        foreach (Type type in assembly.GetTypes())
        {
            // Create object of the class
            object instance = Activator.CreateInstance(type);

            // Scan methods of the class
            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                // Check if method has [Runnable]
                if (method.GetCustomAttribute<RunnableAttribute>() != null)
                {
                    Console.WriteLine($"Executing: {type.Name}.{method.Name}");
                    method.Invoke(instance, null);
                }
            }
        }

        Console.WriteLine("\nExecution finished.");
    }

}