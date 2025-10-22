
/*

using System;
using System.Collections.Generic;
public class Program{



    static void Main(string[] args)
    {

        List<string> student = new List<string>();

        // add studnet
        student.Add("ehtasham ");
        student.Add("ali");
        student.Add("khan");
        student.Add("Ahmed");
        student.Add("Atiya ");

        // add multiple stuidnet
        student.AddRange(new string[] { "aisha", "amina" });


        // insert at specific index
        student.Insert(2, "hamza");

        // display all astudent

        Console.WriteLine("all studnet here ");
        foreach (var s in student)
        {
            Console.WriteLine(s);
        }

        // count total student 
        Console.WriteLine(student.Count);

        // acees by index 
        Console.WriteLine(student[3]);
        Console.WriteLine(student[1]);
        Console.WriteLine(student[4]);

        // check the the studnet exits 
        Console.WriteLine("studnet exist?" + student.Contains("ehtasham"));
        Console.WriteLine("studnet exist?" + student.Contains("sara "));
        Console.WriteLine("studnet exist?" + student.Contains("hamza "));


        // find by index

        Console.WriteLine("index of ahmed " + student.IndexOf("ehtasham"));
        Console.WriteLine("index of ahmed " + student.IndexOf("hamza "));
        Console.WriteLine("index of ahmed " + student.IndexOf("sara "));


        // remove student
        student.Remove("ehtasham");
        student.Remove("khan");

        // remove at index

        student.RemoveAt(0);
        student.RemoveAt(3);


        // Step 11: Remove multiple students
        student.RemoveRange(1, 4);

        // Step 12: Find students starting with 'A'
        List<string> aStudent = student.FindAll(s => s.StartsWith("A"));
        Console.WriteLine("Students starting with A:");
        aStudent.ForEach(s => Console.WriteLine(s));


       
        // Step 13: Sort students alphabetically
        student.Sort();
        Console.WriteLine("Sorted Students:");
        student.ForEach(s => Console.WriteLine(s));

       
       
        // Step 14: Reverse the list
        student.Reverse();
        Console.WriteLine("Reversed Students:");
        student.ForEach(s => Console.WriteLine(s));

        
        // Step 15: Convert names to uppercase using ConvertAll
        List<string> upperStudent = student.ConvertAll(s => s.ToUpper());
        Console.WriteLine("Students in Uppercase:");
        upperStudent.ForEach(s => Console.WriteLine(s));


        
        // Step 16: Clear the list
        student.Clear();
        Console.WriteLine("Total students after clear: " + student.Count);





    }
}
*/