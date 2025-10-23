
// call back thraed practice
/*

using System;
using System.Threading;

public class Student
{
    
    public void ShowInfo(Action<string> callback)
    {
        Console.WriteLine("Fetching student information...");
        Thread.Sleep(1000); 

        string message = "Hello, I am Ehtasham from Abbottabad!";
        callback(message); 
    }

    
    public void Show(string msg)
    {
        Console.WriteLine("The message is: " + msg);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        
        Thread t = new Thread(() => s.ShowInfo(s.Show));

        
        t.Start();

        Console.WriteLine("data loading ");
    }
}

*/
