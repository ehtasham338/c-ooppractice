//custome atrribute +latebinding parctice

/*

using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class InfoAttribute : Attribute
{
    public string Author { get; set; }
    public string Purpose { get; set; }

    public InfoAttribute(string author, string purpose)
    {
        Author = author;
        Purpose = purpose;
    }
}

public class Calculator
{
    [Info("Ehtasham", "Add two numbers")]
    public int showadd()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        return num1 + num2;
    }

    [Info("Ehtasham", "Subtract two numbers")]
    public void showsub()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result (Subtract): {num1 - num2}");
    }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Calculator);


        Console.WriteLine("Available Methods and Their Info:");
        foreach (var method in t.GetMethods())

        {
            foreach (var attr in method.GetCustomAttributes(false))
            {

                if (attr is InfoAttribute info)

                {
                    Console.WriteLine($"\nMethod: {method.Name}");
                    Console.WriteLine($"Author: {info.Author}");
                    Console.WriteLine($"Purpose: {info.Purpose}");
                }
            }
        }


        Console.WriteLine("\nEnter method name to execute (showadd/showsub):");
        string? methodName = Console.ReadLine();



        MethodInfo? selectedMethod = t.GetMethod(methodName ?? "");
        object? obj = Activator.CreateInstance(t);



        if (selectedMethod != null && obj != null)
        {
            var result = selectedMethod.Invoke(obj, null);
            if (result != null)
                Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Method not found!");
        }


    }


    

}
*/
