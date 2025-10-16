// reafctioj practice 

/*

using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json; 

[Serializable]
public class Student
{
    public string name { get; set; }
    public string address { get; set; }
    public int id;
    private int secretcode;

    public Student(string name, string address, int id, int password)
    {
        this.name = name;
        this.address = address;
        this.id = id;
        this.secretcode = password;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Student se = new Student("Ehtasham", "Abbottabad", 121, 305);


        string json = JsonSerializer.Serialize(se);
        Console.WriteLine("\nSerialized JSON:");
        Console.WriteLine(json);

        
        Type typeinfo = se.GetType();
        Console.WriteLine("\nClass Name: " + typeinfo.Name);

        Console.WriteLine("\nAttributes on Class:");
        object[] attributes = typeinfo.GetCustomAttributes(false);
        foreach (var attr in attributes)
        {
            Console.WriteLine(" - " + attr.GetType().Name);
        }


    }



}

*/
