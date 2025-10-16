
/*

using System;
using System.Web.Services;
[WebService(Namespace = "http://www.web.com")]
public class StudentService
{
    [WebMethod]  // <-- Method ke upar ye lagana chahiye
    public string GetStudentName(int id)
    {
        if (id == 1)
            return "Ehtasham";
        else
            return "Unknown";
    }
}

class Program
{
    static void Main()
    {
        StudentService se = new StudentService();
        string result = se.GetStudentName(1);
        Console.WriteLine("Student Name: " + result);
    }
}

*/