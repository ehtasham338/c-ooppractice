
// method hiding exapmle

/*
using System;
public class Parent
{
    public string name;
    public int age;
    public Parent(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void showinfo()
    {
        Console.WriteLine("the name of parent is " + name);
        Console.WriteLine("the age  of parent is " + age);

    }
}

public class Child:Parent
{
    public string address;
    public Child(string name, int age, string address)
        : base(name, age)
    {
        this.address = address;
    }
    public new void showinfo()
    {
        Console.WriteLine("the name of child is "+ address);

    }
}

public class Progarm
{
    static void Main(string[] args)
    {
       Parent p1 = new Child("Ehtasham", 25, "Abbottabad");
        p1.showinfo();

         Console.WriteLine("\n---\n");

        Child c1 = new Child("ali", 25, "Abbottabad");
        c1.showinfo();   // Calls Child.showinfo()
    }
}


*/