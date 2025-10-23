using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Program started..."); 

        await MakeTeaAsync();  

        Console.WriteLine("Program finished.");  
    }

    static async Task MakeTeaAsync()
    {
        Console.WriteLine("Making tea...");       
        await Task.Delay(5000);                    
        Console.WriteLine("Tea is ready!");    
    }
}
