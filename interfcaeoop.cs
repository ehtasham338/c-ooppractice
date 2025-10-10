// interface example 

/*

public interface ITruck
{
    void LoadCargo(int weight);
    void Drive();
}
public class CargoTruck : ITruck
{
    public string TruckName;
    public int Capacity;

    public CargoTruck(string name, int capacity)
    {
        TruckName = name;
        Capacity = capacity;
    }

    public void LoadCargo(int weight)
    {
        Console.WriteLine($"{TruckName} loaded with {weight} tons of cargo (Capacity: {Capacity} tons).");
    }

    public void Drive()
    {
        Console.WriteLine($"{TruckName} is driving on the highway.");
    }
}

// Fuel truck class
public class FuelTruck : ITruck
{
    public string TruckName;
    public int FuelCapacity;

    public FuelTruck(string name, int capacity)
    {
        TruckName = name;
        FuelCapacity = capacity;
    }

    public void LoadCargo(int weight)
    {
        Console.WriteLine($"{TruckName} loaded with {weight} liters of fuel (Capacity: {FuelCapacity} liters).");
    }

    public void Drive()
    {
        Console.WriteLine($"{TruckName} is driving safely transporting fuel.");
    }
}

// Refrigerated truck class


public class RefrigeratedTruck : ITruck
{
    public string TruckName;
    public int CoolingCapacity;

    public RefrigeratedTruck(string name, int coolingCapacity)
    {
        TruckName = name;
        CoolingCapacity = coolingCapacity;
    }

    public void LoadCargo(int weight)
    {
        Console.WriteLine($"{TruckName} loaded with {weight} tons of perishable goods (Cooling Capacity: {CoolingCapacity} tons).");
    }

    public void Drive()
    {
        Console.WriteLine($"{TruckName} is driving while keeping cargo refrigerated.");
    }
}

*/