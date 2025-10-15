// Serializable


/*
using System;
using System.Text.Json;  


[Serializable]  
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()

    {

        Student s = new Student { Name = "Ali", Age = 20 };

        
        
        string jsonString = JsonSerializer.Serialize(s);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonString);

        
        Student newStudent = JsonSerializer.Deserialize<Student>(jsonString);


        Console.WriteLine("Deserialized object:");
        
        Console.WriteLine("Name: " + newStudent.Name);
        Console.WriteLine("Age: " + newStudent.Age);
    }
}

*/
