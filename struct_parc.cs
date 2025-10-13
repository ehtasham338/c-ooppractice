using System;
public struct Student
{
    public string name;
    public int age;
    public int id;
    public Student(string name, int age, int id)
    {
        this.name = name;
        this.age = age;
        this.id = id;

    }
    public void showinfo()
    {
        Console.WriteLine("the name of student is " + name);
        Console.WriteLine("the age of student is " + age);
        Console.WriteLine("the id of student is " + id);

    }
}

public class Program
{
    static void Main(string[] args)
    {
        
        Student s1 = new Student("Ali", 20, 101);

    
        s1.showinfo();
    }
}