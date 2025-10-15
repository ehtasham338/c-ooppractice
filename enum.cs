// enums practice

/*




using System;

public enum UserRole
{
    Admin,
    Customer,
    Technician
}

public enum OrderStatus
{
    Pending,
    Unpending,
    Shipped,
    Delivered
}

public class User
{
    public string Name { get; set; }
    public UserRole Role { get; set; }
}

public class Order
{
    public string OrderType { get; set; }
    public OrderStatus Status { get; set; }  
}

public class Program
{
    static void Main(string[] args)

    {
        User u1 = new User { Name = "Ehtasham", Role = UserRole.Admin };
        User u2 = new User { Name = "Ali", Role = UserRole.Customer };
        User u3 = new User { Name = "Hamza", Role = UserRole.Technician };



        Console.WriteLine($"{u1.Name} is an {u1.Role}");
        Console.WriteLine($"{u2.Name} is an {u2.Role}");
        Console.WriteLine($"{u3.Name} is an {u3.Role}");




        Order od1 = new Order { OrderType = "Pen", Status = OrderStatus.Pending };
        Order od2 = new Order { OrderType = "Cat", Status = OrderStatus.Unpending };
        Order od3 = new Order { OrderType = "Fan", Status = OrderStatus.Shipped };
        Order od4 = new Order { OrderType = "Boxes", Status = OrderStatus.Delivered };



        Console.WriteLine($"{od1.OrderType} order is {od1.Status}");
        Console.WriteLine($"{od2.OrderType} order is {od2.Status}");
        Console.WriteLine($"{od3.OrderType} order is {od3.Status}");
        Console.WriteLine($"{od4.OrderType} order is {od4.Status}");
    }

}

*/
