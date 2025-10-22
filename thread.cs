// thhread start without parameter
/*
using System;
using System.Threading;

public class Threadprogarm
{
    public static void showwork()
    {

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Work 1 can be done");
            Thread.Sleep(1000);
        }

    }

    public static void workdisplay()

    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Work 2 can be done");
            Thread.Sleep(1000);
        }

    }

}

public class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(Threadprogarm.showwork); 
        Thread t2 = new Thread(Threadprogarm.workdisplay);    

        t1.Start(); 
        t2.Start(); 

        Console.WriteLine("Main program still running");

        
        t1.Join();
        t2.Join();

        Console.WriteLine("All threads finished");
    }
}

*/
