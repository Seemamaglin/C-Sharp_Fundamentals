using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter item to add: ");
                    string addItem = Console.ReadLine().Trim().ToUpper();
                    items.Add(addItem);
                    Console.WriteLine("Item added successfully.");
                    break;

                case "2":
                    Console.Write("Enter item to remove: ");
                    string removeItem = Console.ReadLine().Trim().ToUpper();

                    if (items.Remove(removeItem))
                        Console.WriteLine("Item removed successfully.");
                    else
                        Console.WriteLine("Item not found.");
                    break;

                case "3":
                    if (items.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Items in the list:");
                        foreach (string item in items)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}