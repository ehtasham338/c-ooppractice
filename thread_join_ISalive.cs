// thread join and isalive parctice 
/*


using System;
using System.Threading;

public class Tea
{
    public void maketea()
    {
        Console.WriteLine("The tea is making...");
        Thread.Sleep(4000); 
        Console.WriteLine("The tea is ready, Ehtasham!");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Tea te = new Tea();  
        Thread ti = new Thread(te.maketea); 

        ti.Start(); 

        Console.WriteLine("Kya chai ban rahi hai? " + ti.IsAlive);

        ti.Join(); 

        Console.WriteLine("is tea is ready? " + ti.IsAlive);
        Console.WriteLine("ye you try and drink tea ");
    }
}

*/
