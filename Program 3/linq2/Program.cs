using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> studentRecords = new Dictionary<int, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student by ID");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Student ID (integer): ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        if (studentRecords.ContainsKey(id))
                        {
                            Console.WriteLine("Error: A student with this ID already exists.");
                        }
                        else
                        {
                            Console.Write("Enter Student Name: ");
                            string name = Console.ReadLine();
                            studentRecords.Add(id, name);
                            Console.WriteLine("Student added successfully.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID. Please enter an integer.");
                    }
                    break;

                case "2":
                    Console.Write("Enter the ID of the student to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        if (studentRecords.Remove(removeId))
                        {
                            Console.WriteLine("Student removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID. Please enter an integer.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nAll Student Records:");
                    if (studentRecords.Count == 0)
                    {
                        Console.WriteLine("No students found.");
                    }
                    else
                    {
                        foreach (var record in studentRecords)
                        {
                            Console.WriteLine($"ID: {record.Key}, Name: {record.Value}");
                        }
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                    break;
            }
        }
    }
}
