using System;

namespace SimpleTodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[100];
            string[] dates = new string[100];
            bool[] completed = new bool[100];
            int taskCount = 0;
            int command = 0;

            while (command != 5)
            {
                Console.Clear();
                Console.WriteLine("Simple To-Do List:");
                Console.WriteLine("-------------------");
                for (int i = 0; i < taskCount; i++)
                {
                    if (completed[i])
                    {
                        Console.WriteLine($"{i + 1}. [X] {tasks[i]} - {dates[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. [0] {tasks[i]} - {dates[i]}");
                    }
                }
                Console.WriteLine("\nCommands: 1. Add  2. Delete  3. Edit  4. Complete  5. Exit");
                Console.Write("\nEnter a command: ");
                command = int.Parse(Console.ReadLine());

                if (command == 1)
                {
                    if (taskCount < 100)
                    {
                        Console.Write("Enter a new task: ");
                        tasks[taskCount] = Console.ReadLine();
                        Console.Write("Enter the due date: ");
                        dates[taskCount] = Console.ReadLine();
                        completed[taskCount] = false;
                        taskCount++;
                    }
                    else
                    {
                        Console.WriteLine("Task list is full!");
                        Console.ReadKey();
                    }
                }
                else if (command == 2)
                {
                    Console.Write("Enter the number of the task to delete: ");
                    int taskNumber = int.Parse(Console.ReadLine()) - 1;
                    if (taskNumber >= 0 && taskNumber < taskCount)
                    {
                        for (int i = taskNumber; i < taskCount - 1; i++)
                        {
                            tasks[i] = tasks[i + 1];
                            dates[i] = dates[i + 1];
                            completed[i] = completed[i + 1];
                        }
                        taskCount--;
                    }
                }
                else if (command == 3)
                {
                    Console.Write("Enter the number of the task to edit: ");
                    int taskNumber = int.Parse(Console.ReadLine()) - 1;
                    if (taskNumber >= 0 && taskNumber < taskCount)
                    {
                        Console.Write("Enter the new task: ");
                        tasks[taskNumber] = Console.ReadLine();
                        Console.Write("Enter the new due date: ");
                        dates[taskNumber] = Console.ReadLine();
                    }
                }
                else if (command == 4)
                {
                    Console.Write("Enter the number of the task to mark as completed: ");
                    int taskNumber = int.Parse(Console.ReadLine()) - 1;
                    if (taskNumber >= 0 && taskNumber < taskCount)
                    {
                        completed[taskNumber] = true;
                    }
                }
            }
        }
    }
}
