/*



using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Class)] 

public class InfoAttribute : Attribute
{
    public string Author { get; }
    public string Purpose { get; }

    public InfoAttribute(string author, string purpose)
    {
        Author = author;
        Purpose = purpose;
    }
}


[Info("Ehtasham", "Demonstrate Late Binding with Attribute")]

public class Worker
{
    public void DoWork()
    {
        Console.WriteLine("Work done by Worker class!");
    }
}


class Program
{
    static void Main()
    {

        Type t = typeof(Worker);


        Console.WriteLine(" Attributes on class:");

        object[] attrs = t.GetCustomAttributes(false);
        foreach (var attr in attrs)
        {
            Console.WriteLine($" - {attr.GetType().Name}");



            if (attr is InfoAttribute info)
            {
                Console.WriteLine($"   Author: {info.Author}");
                Console.WriteLine($"   Purpose: {info.Purpose}");
            }
        }


        object? obj = Activator.CreateInstance(t);


        MethodInfo? method = t.GetMethod("DoWork");

        if (method != null && obj != null)
        {
            Console.WriteLine("\nCalling method dynamically (Late Binding):");
            method.Invoke(obj, null);

        }


        else
        {
            Console.WriteLine("Method or object not found!");
        }


    }

    

}


*/