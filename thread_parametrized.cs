using System;
using System.Threading;

public class ThreadProgram
{
    public static void cleanroom(object roomnumber)
    {
        Console.WriteLine("Clean the room " + roomnumber);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ParameterizedThreadStart(ThreadProgram.cleanroom));
        t1.Start(101);

        Console.WriteLine("Main thread running...");
    }
}
