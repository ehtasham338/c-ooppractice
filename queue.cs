
// queue practice and method 
/*

using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Marks: {Marks}, Age: {Age}, Gender: {Gender}";
    }
}

public class Program
{
    static void Main(string[] args)
    {

        Queue<Student> students = new Queue<Student>();


        students.Enqueue(new Student { Name = "Ehtasham", Marks = 45, Age = 21, Gender = "Male" });
        students.Enqueue(new Student { Name = "Ali", Marks = 78, Age = 22, Gender = "Male" });
        students.Enqueue(new Student { Name = "Ayesha", Marks = 90, Age = 20, Gender = "Female" });


        Console.WriteLine(" All Students in Queue:");
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine(" Removing student data (FIFO order):");


        var removed = students.Dequeue();
        Console.WriteLine("Removed Student → " + removed);



        Console.WriteLine(" Remaining Students in Queue:");
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }


    }
    



}

*/
