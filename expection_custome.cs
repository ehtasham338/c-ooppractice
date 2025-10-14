using System;


public class CarStartException : Exception
{
    public CarStartException(string message) : base(message)
    {


    }
    
}

public class Car
{
    public static void StartCar()
    {
        bool batteryDead = true;

        if (batteryDead)
        {
            
            throw new CarStartException("Car cannot start because the battery is dead");
        }
    }
}


public class Program
{
    static void Main(string[] args)

    {

        try

        {
            Car.StartCar();
        }


        catch (CarStartException ex)

        {
            Console.WriteLine("Custom Exception Caught= " + ex.Message);
        }
    }
    
}
