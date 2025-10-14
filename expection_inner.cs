// inner expection practice

/*

using System;

public class Car
{
    static void startengine()
    {
        throw new Exception("Battery is dead.");
    }

    static void startcar()
    {
        try
        {
            startengine();
        }
        catch (Exception ex)
        {
            throw new Exception("Car failed to start.", ex);
        }
    }

    public static void Run()
    {
        startcar();
    }
}

public class Program
{
    static void Main()
    {
        try
        {
            
            Car.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Outer Exception: " + ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
            }
        }
    }
}


*/