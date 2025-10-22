// imnplement dictinary all method
/*
using System;
using System.Collections.Generic;

public class Dictionarymethod
{
    static void Main(string[] args)
    {
        Dictionary<int, string> student = new Dictionary<int, string>();

        // Add students
        student.Add(101, "ehtashm");
        student.Add(102, "ali");
        student.Add(103, "mohiz");

        Console.WriteLine("All students added successfully!\n");

        // Print all students
        Console.WriteLine("Printing all students:");
        foreach (var s in student)
        {
            Console.WriteLine($"Roll No: {s.Key}, Name: {s.Value}");
        }

        // Check if key exists
        if (student.ContainsKey(101))
        {
            Console.WriteLine("\nYes! Student found with Roll No 101.");
        }

        // Safely get value
        Console.WriteLine("\nGetting student name by Roll No 102...");
        string name;
        if (student.TryGetValue(102, out name))
        {
            Console.WriteLine("Student Name: " + name);
        }
        else
        {
            Console.WriteLine("Student not found!");
        }

        // Remove student
        student.Remove(101);
        Console.WriteLine("\nStudent removed successfully!");

        // Show remaining students
        Console.WriteLine("\nUpdated Student List:");
        foreach (var s in student)
        {
            Console.WriteLine($"Roll No: {s.Key}, Name: {s.Value}");
        }

        // Show total students
        Console.WriteLine("\nTotal students: " + student.Count);

        // Show all keys
        Console.WriteLine("\nAll Keys:");
        foreach (var key in student.Keys)
        {
            Console.WriteLine(key);
        }

        // Show all values
        Console.WriteLine("\nAll Values:");
        foreach (var value in student.Values)
        {
            Console.WriteLine(value);
        }

        // Clear all data of dtudent
        Console.WriteLine("\nClearing all data");
        student.Clear();
        Console.WriteLine("Dictionary is now empty. Total students = " + student.Count);
    }
}

*/