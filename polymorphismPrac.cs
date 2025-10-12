
/*


using System;

public abstract class Person
{
    protected string name;
    protected int age;
    protected string address;

    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public abstract void ShowDetails();
}

public interface IRegistrable
{
    void Register();
}

public class Student : Person, IRegistrable
{
    private int studentId;
    private string course;

    public Student(string name, int age, string address, int studentId, string course)
        : base(name, age, address)
    {
        this.studentId = studentId;
        this.course = course;
    }

    public void Register()
    {
        Console.WriteLine($"{name} has registered for {course}");
    }

    public void ViewGrade()
    {
        Console.WriteLine($"{name} is viewing grades.");
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Student ID: {studentId}");
        Console.WriteLine($"Course: {course}");
    }
}

public class Teacher : Person
{
    private int teacherId;
    private string subject;

    public Teacher(string name, int age, string address, int teacherId, string subject)
        : base(name, age, address)
    {
        this.teacherId = teacherId;
        this.subject = subject;
    }

    public void AssignGrade()
    {
        Console.WriteLine($"{name} is assigning grades.");
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Teacher Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Teacher ID: {teacherId}");
        Console.WriteLine($"Subject: {subject}");
    }
}

public class Course
{
    private string courseName;
    private string courseCode;
    private int creditHours;

    public Course(string courseName, string courseCode, int creditHours)
    {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.creditHours = creditHours;
    }

    public void ShowInfoCourse()
    {
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Course Code: {courseCode}");
        Console.WriteLine($"Credit Hours: {creditHours}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ehtasham", 23, "ATD", 10, "OOP");
        s1.ShowDetails();
        s1.Register();
        s1.ViewGrade();

        Console.WriteLine();

        Teacher t1 = new Teacher("Sir Ahmed", 35, "Lahore", 201, "progamming");
        t1.ShowDetails();
        t1.AssignGrade();

        Console.WriteLine();

        Course c1 = new Course("OOP", "CS101", 3);
        c1.ShowInfoCourse();
    }
}


*/