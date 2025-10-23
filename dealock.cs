/*
//deadlock 

using System;
using System.Threading;

public class Student
{
    static object pen = new object();
    static object notbook = new object();

    static void Thread1()
    {
        lock (pen)
        {
            Console.WriteLine("the thread pen i slock");
        }

        lock (notbook)
        {
            Console.WriteLine("the thread2 loc the notebook");

        }

    }

    static void Thread2()
    {
        lock (notbook)
        {
            Console.WriteLine("the thread2 loc the notebook");

        }


        lock (pen)
        {
            Console.WriteLine("the thread pen i  lock");
        }

    }
    

    static void Main(string[] args)
    {

        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();

        
        t1.Join();
        t2.Join();

        

     Console.WriteLine("Program finished");



    }


    */