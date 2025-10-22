/*

using System;
using System.Collections.Generic;
public class StudentData
{

    public string name { get; set; }
    public int rollno { get; set; }
    public int age { get; set; }
    public int marks { get; set; }




}

public class Progarm
{
    static void Main(string[] args)
    {

        Dictionary<int, StudentData> students = new Dictionary<int, StudentData>();

        
        students.Add(101, new StudentData { name = "Ehtasham", rollno = 101, age = 25, marks = 98 });
        students.Add(102, new StudentData { name = "Ehtasham Karlal", rollno = 102, age = 25, marks = 95 });
        students.Add(103, new StudentData { name = "Ehtasham Sardar", rollno = 103, age = 25, marks = 99 });


        
        
              foreach (var student in students)
        {
            Console.WriteLine("Roll No: " + student.Key);
            Console.WriteLine("Name: " + student.Value.name);
            Console.WriteLine("Age: " + student.Value.age);
            Console.WriteLine("Marks: " + student.Value.marks);
        }
        

        

        


        
        
        


    }
    



}
*/ 