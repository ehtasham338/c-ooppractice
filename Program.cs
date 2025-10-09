
// inheritance example in C#



using System;
using System.Security.Cryptography;

public class Person
{
    public string name;
    public int age;
    public string address;
    

    // constructor of person class //
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void showdetails()
    {
        Console.WriteLine("Name of person is " + name);
        Console.WriteLine("Age of person is " + age);
        Console.WriteLine("Address of person is " + address);
    }
}


// inheritance class employe from person class

public class Employe : Person
{
    public int salary;
    public int phoneno;

    public Employe(string name, int age, string address, int salary, int phoneno)
        : base(name, age, address)
    {
        this.salary = salary;
        this.phoneno = phoneno;
    }

    public void display()
    {
        Console.WriteLine("Salary of employee is " + salary);
        Console.WriteLine("Phone no of employee is " + phoneno);
    }
}


//  main method 

class Program
{
    public static void Main(string[] args)
    {
        // Employee object
        Employe e1 = new Employe("Ali", 25, "Abbottabad", 50000, 123456);
        e1.showdetails();
        e1.display();

        Console.WriteLine();

        // perason object
        Person p1 = new Person("Sara", 30, "Islamabad");
        p1.showdetails();

        Console.WriteLine();

        Console.WriteLine("encapsualtion exapmle ");

        // student object

        Student s1 = new Student();
        s1.Name = "ehatshma sardar";
        s1.Age = 24;
        s1.Address = "Kpk";
        s1.showdetails();


        //car object
          Console.WriteLine();

        Console.WriteLine("abstarction examplemcode ");

        Toyota t = new Toyota("Toyota Corolla", "White", 2023, 3500000, 180);
        t.showDetails();
        t.carfeature();
        Console.WriteLine();

        Honda h = new Honda("Honda Civic", "Black", 2024, 4200000, 18);
        h.showDetails();
        t.carfeature();
        Console.WriteLine();

        Mercedes m = new Mercedes("Mercedes S-Class", "Silver", 2025, 15000000, 3500);
        m.showDetails();
        t.carfeature();


        Console.WriteLine();
        
       CargoTruck cargo = new CargoTruck("CargoMaster", 20);
FuelTruck fuel = new FuelTruck("FuelKing", 5000);
RefrigeratedTruck fridge = new RefrigeratedTruck("IceTruck", 10);

cargo.LoadCargo(15);
cargo.Drive();
Console.WriteLine();

fuel.LoadCargo(4000);
fuel.Drive();
Console.WriteLine();

fridge.LoadCargo(8);
fridge.Drive();



    }
}


