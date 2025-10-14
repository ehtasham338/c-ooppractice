// multi cast deleagtes 

/*


using System;
public delegate void Mydelegate();
public class Device
{
    public void Tvon()
    {
        Console.WriteLine("the tv is on");

    }

    public void Upvolume()
    {
        Console.WriteLine("volume is up");
    }

    public void Downvolume()
    {

        Console.WriteLine("volume is down");
    }

    public void Changechanel()
    {
        Console.WriteLine("change chanel");

    }

    public void Offtv()
    {
        Console.WriteLine("the tv id off");
    }
}


public class Program
{
    static void Main(string[] args)
    {

        Device d = new Device();
        Mydelegate del = d.Tvon;
        del += d.Upvolume;
        del += d.Changechanel;
        del += d.Downvolume;
        del += d.Offtv;

        del();

        



    }
}


*/