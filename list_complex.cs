/*


using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
    
        List<Student> students = new List<Student>();

        
        students.Add(new Student { Name = "Ehtasham", Marks = 30 });
        students.Add(new Student { Name = "Ali", Marks = 40 });
        students.Add(new Student { Name = "Khan", Marks = 50 });
        students.Add(new Student { Name = "Ayesha", Marks = 80 });

        
        students.Sort(CompareStudents);

        
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }
    }

    //  Comparison delegate method
    static int CompareStudents(Student s1, Student s2)
    {
        return s1.Marks.CompareTo(s2.Marks);
    }
}

*/
