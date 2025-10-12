
/*

using System;
public class Student
{

    public string name;
    public int rollno;
    public int marks;

    public Student(string name, int rollno, int marks)
    {
        this.name = name;
        this.rollno = rollno;
        this.marks = marks;
    }
    public void displayinfo()
    {
        Console.WriteLine("name of student " + name);
        Console.WriteLine("rollno of student " + rollno);
        Console.WriteLine("marks of student " + marks);
    }




}

public class Course{
    public string coursename;
    public int code;
    public int page;

    public Course(string coursename,int code,int page){
        this.coursename=name;
        this.code=code;
        this.page=page;

    }

    public void show(){
        Console.WriteLine("the name of book "+cousrename);
        Console.WriteLine("the code of book is "+code);
        Console.WriteLine("the total page of book"+page);
    }


}

public class Program
{
    static void Main(string[] args)
    {
        // enetr the total student
        Console.WriteLine("enter the totalstudent ");
        int totalstudent = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[totalstudent];
        for (int i = 0; i < totalstudent; i++)
        {
            Console.WriteLine("enter the name ");
            string name = Console.ReadLine();

            Console.WriteLine("enter the marks ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the  rollno ");
            int rollno = Convert.ToInt32(Console.ReadLine());

            students[i] = new Student(name, rollno, marks);
        }

        
              
               Console.WriteLine("Students Information");

        foreach (var s in students)
        {
            s.displayinfo();
            
        }



        
        

    }
}
*/