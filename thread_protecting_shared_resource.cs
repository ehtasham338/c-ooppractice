
// protecting shared resource practice 
/*
using System;
using System.Threading;
public class Bank
{
    static int balnce = 0;
    static object locker = new object();

    static void Deposit()
    {
        
        for (int i = 1; i < 100; i++)
              
              lock (locker)

            balnce = balnce + 1;
    }
    

    static void Main(string[] args)
    {


        Thread t1 = new Thread(Deposit);
        Thread t2 = new Thread(Deposit);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

         Console.WriteLine("Final Balance (without protection): " + balnce);




    }
    


}
*/