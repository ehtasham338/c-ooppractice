// abstarction example practice;
using System;


public abstract class Car
{
    public string name;
    public string colour;
    public int models;
    public int price;

    public abstract void carfeature();


    public void showDetails()
    {
        Console.WriteLine("Name of car is " + name);
        Console.WriteLine("Color of car is " + colour);
        Console.WriteLine("Model of car is " + models);
        Console.WriteLine("Price of car is " + price);
    }

    public Car(string name, string colour, int models, int price)
    {
        this.name = name;
        this.colour = colour;
        this.models = models;
        this.price = price;
    }
}

public class Toyota : Car
{
    public int Speed;

    public Toyota(string name, string colour, int models, int price, int speed)
        : base(name, colour, models, price)
    {
        this.Speed = speed;
    }

    public override void carfeature()
    {
        Console.WriteLine("Speed of car is " + Speed + " km/h");
    }
}

public class Honda : Car
{
    public int milage;
    public Honda(string name,string colour,int models,int price,int milage)
        : base(name, colour, models, price)
    {
        this.milage = milage;
    }
    public override void carfeature()
    {
        Console.WriteLine("Milage of car is  " + milage);
    }
}
public class Mercedes : Car
{
    public int engine;
    public Mercedes(string name, string colour, int models, int price, int engine)
        : base(name, colour, models, price)
    {
        this.engine = engine;
    }
    public override void carfeature()
    {
        Console.WriteLine("Engine of car is  " + engine);
    }
}


