// METHOD HIDING AND OVERRIDING
/*

using System;
public class Animal
{
    public void sound()
    {
        Console.WriteLine("animal sound ");
    }
    public virtual void speak()
    {
        Console.WriteLine("animal spaeak ");
    }
}
public class Dog : Animal
{
    public new void sound()
    {
        Console.WriteLine("dog sound bow bow ");

    }
}

public class Cat : Animal
{
    public override void speak()
    {
        Console.WriteLine("the cat can not speak ");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Dog();
        a1.sound();

        Animal a2 = new Cat();
        a2.speak();
    }
}

*/