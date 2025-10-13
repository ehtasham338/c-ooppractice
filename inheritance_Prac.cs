
// inheritance example

/*
using System;
public class Employe
{
    public string name;
    public int age;
    public int id;
    public string address;

    public Employe(string name, int age, int id, string address)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.address = address;


    }

    public void displayinfo()
    {
        Console.WriteLine("the name of employe is " + name);
        Console.WriteLine("the age of employe is " + age);
        Console.WriteLine("the id of employe is " + id);
        Console.WriteLine("the adress of employe is " + address);
           
    }






}

public class Parttimeemploye : Employe
{

    public int salary;

    public Parttimeemploye(string name, int age, int id, string address, int salary)
        : base(name, age, id, address)
    {
        this.salary = salary;
    }
    public void showsalary()
    {
        Console.WriteLine("the salary of part employe is " + salary);

    }





}
public class Fulltimeemploye : Employe
{
    public int salary;
    public Fulltimeemploye(string name, int age, int id, string address, int salary)
        : base(name, age, id, address)
    {
        this.salary = salary;

    }

    public void showslary()
    {
        Console.WriteLine("the salary of full time  employe is " + salary);
    }
}

public class Program
{
    static void Main(string[] args)
    {


        Parttimeemploye e1 = new Parttimeemploye("eharsham", 24, 101, "abbottabd", 12000);
        e1.displayinfo();
        e1.showsalary();

        Console.WriteLine("\n");


        Fulltimeemploye e2 = new Fulltimeemploye("hamza ", 25, 102, "karchi", 20000);
        e2.displayinfo();
        e2.showslary();
    }
}



*/