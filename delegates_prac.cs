// delegates practice 

/*

using System;


 public delegate void StudentDelegate(int marks);

public class Student
{


    public void DisplayMarks(int marks)
    {
        Console.WriteLine("Student marks: " + marks);
    }


    public void CheckPassFail(int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Status: Pass");
        else
            Console.WriteLine("Status: Fail");
    }
    public class Program
    {
        static void Main()
        {

             
        Student studentObj = new Student();

    
        StudentDelegate studentDel = studentObj.DisplayMarks;   
            studentDel += studentObj.CheckPassFail;                 
        

        // Delegate call
        Console.WriteLine("Student Result ");
        studentDel(75); 

        Console.WriteLine("\nAnother Student:");
        studentDel(35); 
        }
    }
}

*/
