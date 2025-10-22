// partial method practice 

/*

using System;

namespace DemoSpace
{
    
    public partial class Student
    {
        public string name;
        public int age;

        
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;

            
            ShowInfo();
        }

    
        partial void ShowInfo();
    }

    
    public partial class Student
    {
        
        partial void ShowInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }

    
    public class Program
    {
        static void Main(string[] args)
        {
        
            
            Student s1 = new Student("Hamza", 25);

            Console.ReadLine();
        }

    }



}



*/
