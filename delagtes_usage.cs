
// delagtes usage 

/*
using System;
using System.Collections.Generic;


public delegate bool Employedelegates(Employe emp);

public class Employe
{
    public string name { get; set; } 
    public int age { get; set; }
    public int id { get; set; }
    public int experiance { get; set; }

    public Employe(string name, int age, int id, int experiance)
    {
        this.name = name;
        this.id = id;
        this.age = age;
        this.experiance = experiance;
    }

    public void showinfo()

    {
        Console.WriteLine("Name of employee: " + name);
        Console.WriteLine("Age of employee: " + age);
        Console.WriteLine("ID of employee: " + id);
        Console.WriteLine("Experience of employee: " + experiance);
    }

    public static bool PromoteCheck(Employe emp)
    {
        return emp.experiance >= 5;
    }
}



public class Program
{
    public static void PromoteEmployees(List<Employe> employees, Employedelegates IsEligible)
    {
        foreach (Employe emp in employees)
        {
            Console.WriteLine("\n-------------------------------");
            emp.showinfo(); 

            
            if (IsEligible(emp))
            {
                Console.WriteLine($"{emp.name} is promoted!");
            }
            else
            {
                Console.WriteLine($"{emp.name} is not eligible for promotion.");
            }
        }
    }

    static void Main(string[] args)
    {
        
        List<Employe> empList = new List<Employe>()
        {
            new Employe("Ali", 25, 1, 3),
            new Employe("Sara", 28, 2, 6),
            new Employe("Ahmed", 30, 3, 8),
            new Employe("Sana", 22, 4, 2)
        };

        
        Employedelegates del = new Employedelegates(Employe.PromoteCheck);

        
        PromoteEmployees(empList, del);
    }
}


*/