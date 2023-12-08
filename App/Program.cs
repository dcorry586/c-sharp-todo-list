using System;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        PrintInstructions();
        List<string> todos = [];

        while (true)
        {
            Console.WriteLine("Enter command: ");
            string? userInput = Console.ReadLine();
            Console.WriteLine("User input: " + userInput);
            // parse command - if list then list if add then add 


            if (userInput is not null && userInput.Equals("add"))
            {
                Console.WriteLine("> ");
                string taskToAdd = Convert.ToString(Console.ReadLine()) ?? "Unknown Input";
                todos.Add(taskToAdd);
            }

            if (userInput is not null && userInput.Equals("list"))
            {
                PrintAllTodos(todos);
            }

            if (userInput is not null && userInput.Equals("q"))
            {
                Console.WriteLine("Quitting program...");
                Environment.Exit(0);
            }
        }
    }
    static void PrintAllTodos(List<string> list)
    {
        if (list.Count.Equals(0))
        {
            Console.WriteLine("List is empty");
        }

        foreach (var todo in list)
        {
            Console.WriteLine("Todo: " + todo);
        }
    }

    static void PrintInstructions()
    {
        Console.WriteLine("Commands: list to list all todos. Enter add to add task");
    }
}