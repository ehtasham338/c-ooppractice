// type safe usi g dat pas thread example
/*


using System;
using System.Threading;

public class Student
{
    public string name { get; set; }
    public int rollno { get; set; }

    public void showname(int rolno ,string name)
    {
        Console.WriteLine("name and roll no of student is " + name + " " + rolno);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        
        Student s = new Student { name = "ehtashm", rollno = 102 };

        int number = 101;
        string name = "sadd";
        
        Thread t1 = new Thread(() => s.showname(number ,name));
        t1.Start();
    }


}
*/